using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;


namespace CodeWars
{
    class TwoSmallestInt
    {
        public int getSmallestSum(int[] a)
        {
            int[] b = new int[a.Length];
            Array.Copy(a, 0, b, 0, a.Length);
            Array.Sort(b);
            return b[0] + b[1];
        }

        public int getBetterSmallestSum(int[] a)
        {
            return a.OrderBy(i => i).Take(2).Sum();
        }
    }
}
