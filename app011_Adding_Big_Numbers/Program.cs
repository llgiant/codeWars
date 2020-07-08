using System.Numerics;
using System;

namespace app011_Adding_Big_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sumStrings("987429134712934876249385134781395873198472398562384958739845234859234758913759182357398457398474598237459823745928347538", "835743829547328954732895474893754893753281957319857432958432548937859483265893274891378593187431583942678439217431924789"));
            Console.ReadLine();
        }
        public static string Add(string a, string b)
        {          
            return Decimal.Parse(a + b).ToString() ; 
        }

        public static string sumStrings(string a, string b)
        {

            return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
        }
    }
}
