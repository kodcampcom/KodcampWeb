using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Kodcamp.Models.ChatModels;

namespace Kodcamp.Hubs
{
    public class MyHub:Hub
    {
        // Herkese mesajı gönderir. İlk yazılan metodumuz.
        public async Task SendMessageAsync(string message)
        {
            await Clients.All.SendAsync("recieveMessage", message);
        }

        // Porttaki kullanıcının nicknamei alınır listelenir.
        public async Task GetNickName(string nickName, string channelName)
        {
            if (channelName == "programlama")
            {
                Client clientProgramlama = new Client()
                {
                    ConnectionId = Context.ConnectionId,
                    Nickname = nickName,
                    ChannelName = channelName
                };
                ClientSource.ClientsProgramlama.Add(clientProgramlama);

                if (ClientSource.ClientsProgramlama != null && ClientSource.ClientsProgramlama.Count != 0)
                {
                    ClientSource.ClientsProgramlama = ClientSource.ClientsProgramlama.Where(w => w.ChannelName == "programlama").ToList();
                    for (int i = 0; i < ClientSource.ClientsProgramlama.Count; i++)
                    {
                        await Clients.Client(ClientSource.ClientsProgramlama[i].ConnectionId).SendAsync("clientJoined", nickName);
                        await Clients.Client(ClientSource.ClientsProgramlama[i].ConnectionId).SendAsync("clients", ClientSource.ClientsProgramlama);
                        // burası karıştı

                        //await Clients.Others.SendAsync("clientJoined", nickName); 
                        //await Clients.All.SendAsync("clients", ClientSource.Clients);
                    }
                    
                }
            }

            if (channelName == "isletimsistemleri")
            {
                Client clientIsletimSistemleri = new Client()
                {
                    ConnectionId = Context.ConnectionId,
                    Nickname = nickName,
                    ChannelName = channelName
                };

                ClientSource.ClientsIsletimSistemleri.Add(clientIsletimSistemleri);

                if (ClientSource.ClientsIsletimSistemleri != null && ClientSource.ClientsIsletimSistemleri.Count != 0)
                {
                    ClientSource.ClientsIsletimSistemleri = ClientSource.ClientsIsletimSistemleri.Where(w => w.ChannelName == "isletimsistemleri").ToList();
                    for (int i = 0; i < ClientSource.ClientsIsletimSistemleri.Count; i++)
                    {
                        await Clients.Client(ClientSource.ClientsIsletimSistemleri[i].ConnectionId).SendAsync("clientJoined", nickName);
                        await Clients.Client(ClientSource.ClientsIsletimSistemleri[i].ConnectionId).SendAsync("clients", ClientSource.ClientsIsletimSistemleri); 
                    }
                }
            }

        }

        public async Task SendMessageSeletedClientAsync(string message, string clientName, string channelName)
        {
            clientName = clientName.Trim();

            if (channelName == "programlama")
            {
                Client senderClient = ClientSource.ClientsProgramlama.FirstOrDefault(w => w.ConnectionId == Context.ConnectionId);

                //ClientSource.ClientsProgramlama = ClientSource.ClientsProgramlama.Where(w => w.ConnectionId != senderClient.ConnectionId).ToList();

                if (ClientSource.ClientsProgramlama != null && ClientSource.ClientsProgramlama.Count != 0)
                {
                    for (int i = 0; i < ClientSource.ClientsProgramlama.Count; i++)
                    {
                        if (ClientSource.ClientsProgramlama[i].ConnectionId != senderClient.ConnectionId)
                        {
                            await Clients.Client(ClientSource.ClientsProgramlama[i].ConnectionId).SendAsync("recieveMessage", message, senderClient.Nickname, channelName);
                        }
                        
                    }
                }
            }

            if (channelName == "isletimsistemleri")
            {
                Client senderClient = ClientSource.ClientsIsletimSistemleri.FirstOrDefault(w => w.ConnectionId == Context.ConnectionId);

                //ClientSource.ClientsIsletimSistemleri = ClientSource.ClientsIsletimSistemleri.Where(w => w.ConnectionId != senderClient.ConnectionId).ToList();

                if (ClientSource.ClientsIsletimSistemleri != null && ClientSource.ClientsIsletimSistemleri.Count != 0)
                {
                    for (int i = 0; i < ClientSource.ClientsIsletimSistemleri.Count; i++)
                    {
                        if (ClientSource.ClientsIsletimSistemleri[i].ConnectionId != senderClient.ConnectionId)
                        {
                            await Clients.Client(ClientSource.ClientsIsletimSistemleri[i].ConnectionId).SendAsync("recieveMessage", message, senderClient.Nickname, channelName);
                        }
                    }
                }
            }
        }

    }

    // Client bilgilerini depolayacağımız alan.
    public static class ClientSource
    {
        public static List<Client> ClientsProgramlama { get; set; } = new List<Client>(); // Nesne başlangıçta da bulunsun diye new List ile doldurduk. Sadece get işlemi yapabilsin.
        public static List<Client> ClientsIsletimSistemleri { get; set; } = new List<Client>();
        public static List<Client> ClientsDonanim { get; set; } = new List<Client>();
    }
}
