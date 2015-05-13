using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Larger_Than_Neighbours
{
    class LargerThanNeighbours
    {
        static void Main()
        {
            int[] numbers = new[] {1, 3, 4, 5, 1, 0, 5};

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(IsLargerThanNeighbours(numbers,i));
            }
        }

        private static bool IsLargerThanNeighbours(int[] numbers, int i)
        {
            bool result = false;
            if (i==0)
            {
                if (numbers[i]>numbers[i+1])
                {
                    result = true;
                }
            }
            if (i==numbers.Length-1)
            {
                if (numbers[i]>numbers[i-1])
                {
                    result = true;
                }
            }
            if (i>0 && i<numbers.Length-1)
            {
                if (numbers[i]>numbers[i-1] && numbers[i]>numbers[i+1])
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
