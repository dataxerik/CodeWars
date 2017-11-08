using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class Mumbling
    {
        public static string Accum(string s)
        {
            StringBuilder mumblingString = new StringBuilder();
            for(int i = 0; i < s.Length; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    if (j == 0) {
                        mumblingString.Append(Char.ToUpper(s[i]));
                    } else {
                        mumblingString.Append(Char.ToLower(s[i]));
                    }
                }

                if (i != s.Length-1)
                {
                    Console.WriteLine(mumblingString);
                    Console.WriteLine(i);
                    mumblingString.Append("-");
                }
            }
            return mumblingString.ToString();
        }

        public static string BetterAccum(string s)
        {
            return string.Join("-", s.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));
        }
    }
}
