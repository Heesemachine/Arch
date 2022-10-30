using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var field = new Engine.Field(100, 100);
            var random = new System.Random();
            int we = 0;
            int he = 0;

            string addrs = "";
            var addresscounter = 100;
            var conv = Convert.ToInt32(Math.Sqrt(addresscounter));
            var mx = new int[conv, conv];
            Console.WriteLine("=============Matrix===============");
            for (int i = 0; i < addresscounter; i++)
            {
                var home = field.MakeHome(random.Next(addresscounter * 2), random.Next(16), we, he);
                var e = conv;
                we++;
                mx.SetValue(home.address, home.x, home.y);
                if (0 >= we % e)
                {
                    we = 0;
                    he++;
                    Console.Write(home.address + " ");
                    Console.WriteLine();
                }
                else
                    Console.Write(home.address + " ");
                if (home.residents == 0)
                    addrs = home.address + " " + addrs;

            }
            Console.WriteLine();
            Console.WriteLine("=============Empty Home's===============");
            Console.WriteLine(addrs);
            Console.WriteLine("=============Spiral===============");

            Utils.Spiral(mx);

            Console.ReadLine();
        }
        
    }


    

}