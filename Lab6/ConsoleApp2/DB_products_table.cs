using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class DB_anime_table
    {
        private List<Anime> animes = new List<Anime>();

        public DB_anime_table Add(Anime anime)
        {
            animes.Add(anime);
            return this;
        }

        public List<Anime> GetAnimes()
        {
            return animes;
        }

        public void Display()
        {
            foreach (Anime anime in animes)
            {
                Console.WriteLine(anime);
            }
        }

        public List<Anime> Filter(string name)
        {
            return animes.Where(item => item.Name.Contains( name.ToLower() )).ToList();
        }

        public Anime GetByName(string name)
        {
            return animes.Find(item => item.Name == name);
        }
    }
}
