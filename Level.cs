using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGame
{
    internal class Level
    {
        private bool isWater;
        private int width;
        private int height;
        private GameObject[] objects;
        private GameObject[,] map;

        public Level(bool isWater, int width, int height, GameObject[] objects)
        {
            this.isWater = isWater;
            this.width = width;
            this.height = height;
            this.objects = objects;

            this.map = new GameObject[height, width];

            int successful = 0; // Amount of successfully placed objects

            Console.WriteLine("\t--- Initializing level bilding. Placing " + objects.Length + " objects. ---\n");

            // Level bilding
            for (int i = 0; i < objects.Length; i++)
            {
                Console.Write((i + 1).ToString() + ". ");

                // If object X coord is out of map bounds - skip it
                if (objects[i].GetX() >= width || objects[i].GetX() < 0)
                {
                    Console.WriteLine(String.Format("ERROR | Skipping GameObject | GameObject {0} X coord is out of map (0 > {1} >= {2})", objects[i].GetID(), objects[i].GetX(), width));
                    continue;
                }

                // If object Y coord is out of map bounds - skip it
                if (objects[i].GetY() >= height || objects[i].GetY() < 0)
                {
                    Console.WriteLine(string.Format("ERROR | Skipping GameObject | GameObject {0} Y coord is out of map (0 > {1} >= {2})", objects[i].GetID(), objects[i].GetY(), width));
                    continue;
                }

                // If there is already another object at new object coords - placing failed, skipping object
                if (this.map[objects[i].GetY(), objects[i].GetX()] != null)
                {
                    Console.WriteLine(string.Format("ERROR | Skipping GameObject | Coordinates of {0} are already occupied by {1}", objects[i].GetID(), this.map[objects[i].GetY(), objects[i].GetX()].GetID()));
                    continue;
                }

                Console.WriteLine(objects[i].GetID() + " - OK.");
                successful++;

                this.map[objects[i].GetY(), objects[i].GetX()] = objects[i];
            }

            // Level built. Printing out amount of successfuly placed objects (amount and percentage)
            Console.WriteLine("\n\t--- Level built. Successfuly placed {0} objects ({1}%) ---\n", successful, (successful * 100) / objects.Length);
        }

        public int GetWidth() { return this.width; }
        public int GetHeight() { return this.height; }
        public GameObject[,] GetMap() { return this.map; }

        // Convert level map to text string
        override public string ToString()
        {
            string result = "";

            for (int y = 0; y < this.height; y++)
            {
                for (int x = 0; x < this.width; x++)
                {
                    if (this.map[y, x] != null)
                    {
                        result += this.map[y, x].GetID()[0] + " ";
                    }

                    else
                    {
                        result += ". ";
                    }
                }
                result += '\n';
            }

            return result;
        }
    }
}
