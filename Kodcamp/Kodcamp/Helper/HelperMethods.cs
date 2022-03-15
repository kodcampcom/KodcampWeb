using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace Kodcamp.Helper
{
    public class HelperMethods
    {
        private Random random = new Random();
        public string GenerateId(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghjklmnoprstyzx";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public string ImageUploadToRoot(IFormFile image, string pathName = "", string imgName = "")
        {
            string rnd = GenerateId(3);
            if (pathName == "profile") rnd = GenerateId(8);
            imgName = ConvertToTurhishChars(imgName);
            imgName = imgName.Replace(" ", "-") + rnd;

            string ImageName = imgName + Path.GetExtension(image.FileName);
            string SavePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/" + pathName + "/", ImageName);
            using (var stream = new FileStream(SavePath, FileMode.Create)) { image.CopyTo(stream); }

            string imageName = Path.GetFileName(SavePath);

            return imageName;
        }

        public string Hash256(string password)
        {
            SHA256 sha = new SHA256CryptoServiceProvider();
            string hashedPassword = Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(password)));

            return hashedPassword;
        }

        public string ConvertToTurhishChars(string word)
        {
            word = word.ToLower();
            word = word.Replace('ç', 'c');
            word = word.Replace('ö', 'o');
            word = word.Replace('ü', 'u');
            word = word.Replace('ş', 's');
            word = word.Replace('ğ', 'g');
            word = word.Replace('ı', 'i');
            word = word.Replace('İ', 'i');
            word = word.Replace("?", "");
            word = word.Replace(".", "");
            word = word.Replace("=", "");
            word = word.Replace("'", "");
            word = word.Replace("/", "");
            word = word.Replace(",", "");
            word = word.Replace("(", "");
            word = word.Replace(")", "");
            word = word.Replace("&", "");
            word = word.Replace("%", "");
            word = word.Replace("+", "");
            return word;

        }

        public string ConvertTitleToId(string word)
        {
            word = word.ToLower();
            word = word.Replace('ç', 'c');
            word = word.Replace('ö', 'o');
            word = word.Replace('ü', 'u');
            word = word.Replace('ş', 's');
            word = word.Replace('ğ', 'g');
            word = word.Replace('ı', 'i');
            word = word.Replace('İ', 'i');
            word = word.Replace("?", "");
            word = word.Replace(".", "");
            word = word.Replace("=", "");
            word = word.Replace("'", "");
            word = word.Replace("/", "");
            word = word.Replace(",", "");
            word = word.Replace("(", "");
            word = word.Replace(")", "");
            word = word.Replace("&", "");
            word = word.Replace("%", "");
            word = word.Replace("+", "");
            word = word.Replace(" ", "-");
            return word;

        }
    }
}
