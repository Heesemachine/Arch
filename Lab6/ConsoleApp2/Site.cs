using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Site
    {
        private DB_anime_table DB_anime = new DB_anime_table()
            .Add(new Anime("Naruto", "senen", 720, "Naruto on Photo"))
            .Add(new Anime("Bleach", "senen resistant", 375, "Ichigo on Photo"))
            .Add(new Anime("OnePiece", "senen", 1100, "3 characters on photo"));

        private AccountManager accountManager = new AccountManager();

        public Site()
        {

        }

        public void Display()
        {
            DB_anime.Display();
        }

        public void LogIn()
        {
            accountManager.LogIn();
        }

        public void LogOut()
        {
            accountManager.LogOut();
        }

        public void Favorite(string name)
        {
            Anime anime = DB_anime.GetByName(name);
            if (anime != null)
            {
                accountManager.Favorite(anime);
            }
            else
            {
                Console.WriteLine("dont find an anime with this name");
            }
        }
    }
}
