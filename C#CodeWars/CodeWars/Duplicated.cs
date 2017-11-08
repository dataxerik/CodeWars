using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class Duplicated
    {
        public static int DuplicateCount(string str)
        {
            return str.GroupBy(s => char.ToUpper(s)).Where(group => group.Count() > 1).Count();
        }
    }
}
