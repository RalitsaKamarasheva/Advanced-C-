using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Last_Digit_of_Number
{
    class LastDigitOfNumber
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetLastDigitAsWord(number));

        }

        static string GetLastDigitAsWord(int number)
        {
            string word=null;
            int remainder = number%10;
            switch (remainder)
            {
                case 0:
                     word = "zero";
                    break;
                case 1:
                    word = "one";
                    break;
                case 2:
                    word = "two";
                    break;
                case 3:
                    word = "three";
                    break;
                case 4:
                    word = "four";
                    break;
                case 5:
                    word = "five";
                    break;
                case 6:
                    word = "six";
                    break;
                case 7:
                    word = "seven";
                    break;
                case 8:
                    word = "eight";
                    break;
                case 9:
                    word = "nine";
                    break;
            }
            return word;
        }
    }
}
