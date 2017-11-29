using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalLetter
{
    class CapitalLetterConsola
    {
        static void Main(string[] args)
        {
            //new int[] { 0, 3, 4, 6 }.ToList().ForEach(Console.WriteLine);
            Library.CapitalLetter.CountCapitals("CodEWaRs").ToList().ForEach(Console.WriteLine);
            //Console.WriteLine(CapitalLetter.Library.CapitalLetter.CountCapitals("CodEWaRs").Equals(new int[] { 0, 3, 4, 6 }));
            
            Console.Read();
        }
    }
}
