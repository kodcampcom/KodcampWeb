var channelName = channelName;

$(document).ready(() => {
    const connection = new signalR.HubConnectionBuilder()
        .withUrl("https://kodcamp.com/myhub/" + channelName).build();
    connection.start();

    // Herkese mesaj gönderme eski hali.
    //$("#btnSend").click(() => {
    //    let message = document.getElementById("txtSender").value;
    //    connection.invoke("SendMessageAsync", message).catch(error => console.log(error));
    //});


    // Seçili kişiye mesaj gönderme ya da herkese gönderme

    $("#btnSend").click(() => {
        const clientName = document.getElementById("hiddenValue").value; // Seçili kişinin (mesajın gönderileceği ismi)
        const message = document.getElementById("txtSender").value;
        connection.invoke("SendMessageSeletedClientAsync", message, clientName, channelName).catch(error => console.log(error));

        // Eğer mesajı ben göndermişsen sistemi yormamak için gönderdiğim mesajı kendi sayfamda yazdırıyorum. Adım da sen oluyor.

        var allMessages = document.getElementById("allMessages");

        var myMessages = document.createElement('div');
        myMessages.classList.add('outgoing_msg');
        allMessages.appendChild(myMessages);

        var myMessages2 = document.createElement('div');
        myMessages2.classList.add('sent_msg');
        myMessages.appendChild(myMessages2);

        var nickNameSpan = document.createElement('span');
        nickNameSpan.appendChild(document.createTextNode("Ben"));
        nickNameSpan.classList.add('badge', 'badge-secondary');
        myMessages2.appendChild(nickNameSpan);

        var myP = document.createElement('p');
        myP.appendChild(document.createTextNode(message));
        myMessages2.appendChild(myP);

        var myS = document.createElement('span');
        var dtTime = GetDateFormat();
        myS.appendChild(document.createTextNode(dtTime));
        myS.classList.add('time_date');
        myMessages2.appendChild(myS);

        message.value = "";

    });

    $("#btnLogin").click(() => {
        const nickName = $("#txtNickname").val();
        if (nickName != "") {
            connection.invoke("GetNickName", nickName, channelName).catch(error => console.log(error)); // Girilen kullanıcı adını alıp, servera gönderiyoruz.
            document.getElementById("loginSystem").classList.remove("d-none");
            document.getElementById("alertLogin").classList.add("d-none");
        }

    });

    $("body").on("click", "#userListElements", function () {
        var degisken = this.textContent;
        document.getElementById("hiddenValue").value = degisken;
        document.getElementById("hiddenValue2").innerHTML = `<b class="alert-link" > ${degisken} </b> kişisi ile oturum başlattınız.`;
        document.getElementById("hiddenValue2").classList.remove("d-none");
    });



    // İlgili mesajı alıp yazan fonksiyonumuz

    connection.on("recieveMessage", (message, nickName, channelName) => {

        var allMessages = document.getElementById("allMessages");

        var myMessages = document.createElement('div');
        myMessages.classList.add('received_msg');
        allMessages.appendChild(myMessages);

        var myMessages2 = document.createElement('div');
        myMessages2.classList.add('received_withd_msg');
        myMessages.appendChild(myMessages2);

        var nickNameSpan = document.createElement('span');
        nickNameSpan.appendChild(document.createTextNode(nickName));
        nickNameSpan.classList.add('badge', 'badge-secondary');
        myMessages2.appendChild(nickNameSpan);

        var myP = document.createElement('p');
        myP.appendChild(document.createTextNode(message));
        myMessages2.appendChild(myP);

        var myS = document.createElement('span');
        var dtTime = GetDateFormat();
        myS.appendChild(document.createTextNode(dtTime));
        myS.classList.add('time_date');
        myMessages2.appendChild(myS);
    })

    // Giriş yapıldığında giriş yapılan kişiyi yazan fonksiyonumuz

    connection.on("clientJoined", nickName => {
        $("#clientDurumMesaj").html(`${nickName} giriş yaptı.`)
        $("#clientDurumMesaj").fadeIn(2000, () => {
            setTimeout(() => {
                $("#clientDurumMesaj").fadeOut(2000);
            }, 2000)
        })
    })

    // Tüm Clientların(nickname olan kişilerin listesini dönelim)

    connection.on("clients", clients => {
        var userList = document.getElementById("userList");

        var divList1 = document.getElementById("divList");
        if (divList1 != null) {
            divList1.remove();
        }

        var div1 = document.createElement("div");
        div1.id = "divList";
        userList.appendChild(div1);

        var list1 = document.createElement("a");
        list1.id = "userListElements";
        list1.classList.add('list-group-item', 'list-group-item-action');
        list1.appendChild(document.createTextNode("Herkese Gönder"));
        div1.appendChild(list1);

        for (var i = 0; i < clients.length; i++) {
            var list1 = document.createElement("a");
            list1.id = "userListElements";
            list1.classList.add('list-group-item', 'list-group-item-action');
            list1.appendChild(document.createTextNode(clients[i].nickname));
            div1.appendChild(list1);
        }

    })


});


GetDateFormat();

function GetDateFormat() {

    var date = new Date();
    var minute = date.getMinutes();
    var hour = date.getHours();
    var day = date.getDate();
    var month = date.getMonth();
    var year = date.getFullYear();
    var second = date.getSeconds();

    var months = ["Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık"];

    var prettyTime = day + " " + months[month] + " " + year + " |  " + hour + ":" + minute + ":" + second;
    return prettyTime;
}



// TxtBox içinde enter tuşuna basılırsa tetikle

function searchKeyPress(e) {
    e = e || window.event;
    if (e.keyCode == 13) {
        document.getElementById('btnSend').click();
        document.getElementById("txtSender").value = "";
        return false;
    }
    return true;
}