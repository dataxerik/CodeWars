using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class SpinningWord
    {
        public static string SpindWords(string sentence)
        {
            StringBuilder temp = new StringBuilder();
            string[] wordArray = sentence.Split(' ');
            for (int i = 0; i < wordArray.Length; i++)
            {
                if(wordArray[i].Length >= 5)
                {
                    temp.Append(string.Join("", wordArray[i].Reverse().ToArray()));
                } else
                {
                    temp.Append(wordArray[i]);
                }

                if(i < wordArray.Length)
                {
                    temp.Append(" ");
                } 
            }

            return temp.ToString();

        }

        public static string SpinWords(string sentence)
        {
            return string.Join(" ", sentence.Split(' ').Select(str => str.Length > 5 ? new string(str.Reverse().ToArray()) : str));
        }
    }
}
