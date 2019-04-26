using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isograms
{
    public class Kata
    {
        public static bool IsIsogram(string str)
        {
            HashSet<char> letters = new HashSet<char>();
            foreach (char c in str)
            {
                letters.Add(c);
            }
            if (letters.Count < str.Length)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
