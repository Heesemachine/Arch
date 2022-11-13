using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Anime
    {
        public int _id { get; }
        public string Name { get; }
        public string Description { get; }
        public string Photo { get;}
        public float SeriesCount { get; }

        public Anime(string name, string description, float seriesCount, string photo)
        {
            Name = name;
            Description = description;
            Photo = photo;
            SeriesCount = seriesCount;
        }

        public override string ToString()
        {
            return $"Name: {Name}, count of series: {SeriesCount}";
        }
    }
}
