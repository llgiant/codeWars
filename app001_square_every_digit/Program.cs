using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Welcome. In this kata, you are asked to square every digit of a number.
 * For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1.
 * Note: The function accepts an integer and returns an integer
*/



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Kata.SquareDigits(9119));//811181
        Console.ReadLine();
    }
}

public class Kata
{
    public static int SquareDigits(int n) //9119
    {
        char[] charArray = n.ToString().ToCharArray();
        string number = "";
        int intNum = 0;
        foreach (char digit in charArray)
        {
            intNum = int.Parse(digit.ToString());
            number += intNum * intNum;
        }

        return int.Parse(number);
    }
}