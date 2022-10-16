using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGame
{
    internal class Decoration : GameObject
    {
        private string type;

        public Decoration(bool isWater, string type, int x, int y) : base(isWater, x, y)
        {
            this.type = type;
        }

        public override string ToString()
        {
            return string.Format("Decoration (type = {0}, coords = ({1}, {2}), water = {3}", this.type, this.x, this.y, this.isWater);
        }

        // ID of Decoration is its type
        public override string GetID() { return this.type; }
    }
}
