using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Account
    {
        public int _id { get; }
        public string _username { get; }
        public string _email { get; }
        public string _password { get; }

        public List<Anime> favorite = new List<Anime> ();

        public Account(string usernamename, string email, string password)
        {
            _id = Convert.ToInt32( new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds());
            _username = usernamename;
            _email = email;
            _password = password;
        }

        public Account Add(Anime anime)
        {
            favorite.Add(anime);
            return this;
        }
        public Account DeleteAnime(Anime anime)
        {
            favorite.Where(item => item._id != anime._id);
            return this;
        }
    }
}
