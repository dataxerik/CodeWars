using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class ConvertorBin
    {
        public static string AddBinary(int a, int b)
        {
            StringBuilder binary = new StringBuilder();
            int sum = a + b;
            while (sum != 0)
            {
                int digit = sum % 2;
                sum = sum / 2;
                if (binary.Length == 0 && digit == 0)
                {
                    continue;
                }
                binary.Append(digit);
            }
            return string.Join("", binary.ToString().Reverse());
        }

        public static string AddBinarySimple(int a, int b)
        {
            return Convert.ToString(a + b, 2);
        }
    }
}
