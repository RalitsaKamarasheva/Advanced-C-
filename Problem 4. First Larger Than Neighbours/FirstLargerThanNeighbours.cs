using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.First_Larger_Than_Neighbours
{
    class FirstLargerThanNeighbours
    {
        static void Main()
        {
            int [] sequenceOne = new[] {1,3,4,5,1,0,5};
            int [] sequenceTwo = new[] {1,2,3,4,5,6,6};
            int [] sequenceThree = new[] {1, 1, 1};
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceOne));
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceTwo));
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceThree));

        }

        static int GetIndexOfFirstElementLargerThanNeighbours(int[] numbers)
        {
            int i=-1;
            for (i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        return i;
                        continue;
                    }
                }
                else if (i == numbers.Length - 1)
                {
                    if (numbers[i] > numbers[i - 1])
                    {
                        return i;
                        continue;
                    }
                }
                if (i > 0 && i < numbers.Length - 1)
                {
                    if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                    {
                        return i;
                       break;
                    }
                }
            }
            if (i==numbers.Length)
            {
                i = -1;
            }
            
            return i;
        }
    }
}
