using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Complete the solution so that it returns true if the first argument(string) passed in ends with the 2nd argument (also a string).
 * Examples:
 * solution('abc', 'bc') // returns true
 * solution('abc', 'd') // returns false
 */
class Program
{
    static void Main(string[] args)
    {

        IEnumerable<string> newList = Kata.OpenOrSenior(new int[][] { });
    foreach(string s in newList)
        {
            Console.WriteLine(s);
        }
        Console.ReadLine();
    }
}

public class Kata
{
    public static IEnumerable<string> OpenOrSenior(int[][] data)
    {

        List<string> list = new List<string>();
        foreach (int[] array in data)
        {
            
            if (array[0] >= 55 && array[1] > 7) { list.Add("Senior"); }
            else { list.Add("Open"); }
           
        }


        return list;
    }
}