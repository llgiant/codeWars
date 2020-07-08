using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app006_Write_Number_in_Expanded_Form
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.ExpandedForm(12));
        }
    }
}

public static class Kata
{
    public static string ExpandedForm(long num)
    {
        string strNum = num.ToString();
        int index = strNum.Length;
        string newStr = "";
        foreach (char number in strNum)
        {
            if (int.Parse(number.ToString()) > 0)
            {
                if (index < strNum.Length) { newStr += " + "; }
                newStr += number;
                for (int i = 1; i < index; i++)
                {
                    newStr += "0";
                }
            }
            index--;
        }
        return newStr;
    }
}
