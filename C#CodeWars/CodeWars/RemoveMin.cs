using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class RemoveMin
    {
        public static List<int> RemoveSmallest(List<int> numbers)
        {
            List<int> temp = numbers.Select(s => s).ToList();
            temp.Remove(numbers.Min());
            Console.WriteLine(string.Join(",", temp.ToArray()));
            return temp;
        }

        public static List<int> RemoveSmallestMinus(List<int> numbers) // Mutates List
        {
            numbers.Remove(numbers.DefaultIfEmpty().Min());
            return numbers;
        }

        public static List<int> RemoveSmalletPlus(List<int> numbers)
        {
            return numbers.Where((x, i) => 1 != numbers.IndexOf(numbers.Min())).ToList();
        }
    }
}
