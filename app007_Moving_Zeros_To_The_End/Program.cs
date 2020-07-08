using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app007_Moving_Zeros_To_The_End
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] array = Kata.MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 });
            Console.ReadLine();
        }
    }
}

public class Kata
{
    public static int[] MoveZeroes(int[] arr)
    {
        List<int> list = new List<int>();
        List<int> zeros = new List<int>();
        int index = 0;

        while (index < arr.Length)
        {
            if (arr[index] > 0) { list.Add(arr[index]); }
            else { zeros.Add(0); }
            index++;
        }

        list.AddRange(zeros);
        return list.ToArray();
    }
}