using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app009_Equal_Sides_Of_An_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindEvenIndex(new int[] { 20, 10, -80, 10, 10, 15, 35 }));
            Console.ReadLine();
        }

        public static int FindEvenIndex(int[] arr)
        {
            int leftSumm = 0;         
            for (int index = 0; index < arr.Length; index++){
                int rightSumm = 0;
                if (index + 1 < arr.Length){
                    for (int innerIndex = index + 1; innerIndex < arr.Length; innerIndex++){
                        rightSumm += arr[innerIndex];
                    }
                }
                if (leftSumm == rightSumm) { return index; }
                leftSumm += arr[index];
            }
            return -1;
        }

    }
}
