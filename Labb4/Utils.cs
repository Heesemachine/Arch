using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4
{
    internal class Utils
    {
        public static void Spiral(int[,] arr)
        {
            int n = arr.GetLength(0);
            int count = n;
            int value = -n;
            int sum = -1;

            do
            {
                value = -1 * value / n;
                for (int i = 0; i < count; i++)
                {
                    sum += value;
                    Console.Write(arr[sum / n, sum % n] + " ");
                }
                value *= n;
                count--;
                for (int i = 0; i < count; i++)
                {
                    sum += value;
                    Console.Write(arr[sum / n, sum % n] + " ");
                }
            } while (count > 0);
        }
    }
}
