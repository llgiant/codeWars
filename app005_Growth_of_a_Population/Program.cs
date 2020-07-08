using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app005_Growth_of_a_Population
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Arge.NbYear(1500, 5, 100, 5000));
            Console.ReadLine();
        }
    }
}

class Arge
{

    public static int NbYear(int p0, double percent, int aug, int p)
    {
        int years = 0;
        int inhabitants;

        do
        {
            inhabitants = p0 + (int)(p0 * percent/100) + aug;
            p0 = inhabitants;
            years++;
        }
        while (inhabitants < p);



        return years;
    }
}