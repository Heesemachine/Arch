using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGame
{
    internal class NPC : GameObject
    {
        private string name;
        private int lifes;

        public NPC(bool isWater, string name, int x, int y, int lifes) : base(isWater, x, y)
        {
            this.name = name;
            this.lifes = lifes;
        }

        override public string ToString()
        {
            return string.Format("NPC (name = {0}, coords = ({1}, {2}), lifes = {3}, water = {4})", this.name, this.x, this.y, this.lifes, this.isWater);
        }

        // ID of NPC is its name
        public override string GetID() { return this.name; }
    }
}
