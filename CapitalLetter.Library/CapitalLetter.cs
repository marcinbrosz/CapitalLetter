using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CapitalLetter.Library
{
    public class CapitalLetter
    {
        public static int[] CountCapitals(string word)
        {

            //with linq
            return word.ToCharArray().Select((x, i) => i).Where(i => word[i].ToString().ToUpper() == word[i].ToString()).ToArray();

            //with Regex
            //return (from Match x in Regex.Matches(word, @"[A-Z]") select x.Index).ToArray();
            /*List<int> list = new List<int>();
            for(int i=0;i < word.Length;i++)
                if (word[i].ToString().ToUpper() == word[i].ToString())
                    list.Add(i);


            return list.ToArray();*/
            
        }
    }
}
