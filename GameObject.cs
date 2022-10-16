using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGame
{
    abstract class GameObject
    {
        protected bool isWater;
        protected int x;
        protected int y;

        public GameObject(bool isWater, int x, int y)
        {
            this.isWater = isWater;
            this.x = x;
            this.y = y;
        }

        public int GetX() { return this.x; }
        public int GetY() { return this.y; }
        abstract public string GetID();
        public bool IsWater() { return this.isWater; }

        // Interation method. Checks if both objects are same type (water or not).
        // If both objects are same type - interraction successful, method returns true, otherwise - interraction failed, method returns false.
        public bool Interract(GameObject obj)
        {
            if (obj.IsWater() != this.IsWater())
            {
                Console.WriteLine("[-] {0} interaction with {1} failed. Objects types are not the same.", this.GetID(), obj.GetID());
                return false;
            }

            Console.WriteLine("[+] {0} successfuly interacted with {1}", this.GetID(), obj.GetID());
            return true;
        }
    }
}
