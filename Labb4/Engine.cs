using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4
{
    internal class Engine
    {
        internal class Field
        {
            public List<object> FieldContainer = new List<object>();
            public Field(int height, int width)
            {
                int we = 0;
                int he = 0;
                for (int i = 0; i < height * width; i++)
                {
                    if (we >= width)
                    {
                        he++;
                        we = 0;
                    }
                    MakeAir(we, he);
                    we++;
                }
            }

            public Home MakeHome(int address, int residents, int x, int y)
            {
                var home = new Home(address, residents, x, y);
                FieldContainer.Add(home);
                return home;
            }
            public Object MakeAir(int x, int y)
            {
                var obj = GetObjByPosition(x, y);
                if (obj != null)
                    FieldContainer.Remove(obj);
                return new Object(x, y);
            }
            public Object GetObjByPosition(int x, int y)
            {
                foreach (var obj in FieldContainer)
                {
                    if (((Object)obj).y == y && ((Object)obj).x == x)
                    {
                        return (Object)obj;
                    }
                }
                return null;
            }
        }
        internal class Object
        {
            public int x;
            public int y;
            public Object(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        internal class Home : Object
        {
            public int residents;
            public int address;
            public Home(int address, int residents, int x, int y) : base(x, y)
            {
                this.address = address;
                this.residents = residents;
                this.x = x;
                this.y = y;
            }
        }
    }
}
