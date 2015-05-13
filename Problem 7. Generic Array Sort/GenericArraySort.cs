using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Generic_Array_Sort
{
    class GenericArraySort
    {
        static void Main()
        {
            int[] numbers = new[] {1, 3, 4, 5, 1, 0, 5};
            string[] strings = new[] {"zaz", "cba", "baa", "azis"};
            DateTime[] dates = new[]
            {
                new DateTime(2002, 3, 1), new DateTime(2015, 5, 6), new DateTime(2014, 1, 1),
            };
            SortArray(numbers);
            Console.WriteLine();
            SortArray(strings);
            Console.WriteLine();
            SortArray(dates);
            Console.WriteLine();

        }

        private static void SortArray(int[] numbers)
        {
            int n = numbers.Length;
            int iMin;
            for (int i = 0; i < n - 1; i++)
            {
                iMin = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] < numbers[iMin])
                    {
                        iMin = j;
                    }
                }
                if (iMin != i)
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[iMin];
                    numbers[iMin] = temp;
                }
            }

                Console.Write(string.Join(", ",numbers));

        }
        private static void SortArray(string[] strings)
        {
            int n = strings.Length;
            int iMin;
            for (int i = 0; i < n - 1; i++)
            {
                iMin = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (strings[j].CompareTo(strings[iMin])==-1)
                    {
                        iMin = j;
                    }
                }
                if (iMin != i)
                {
                    string temp = strings[i];
                    strings[i] = strings[iMin];
                    strings[iMin] = temp;
                }
            }

                Console.Write(String.Join(", ",strings));

        }
        private static void SortArray(DateTime[] dates)
        {
            int n = dates.Length;
            int iMin;
            for (int i = 0; i < n - 1; i++)
            {
                iMin = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (dates[j] < dates[iMin])
                    {
                        iMin = j;
                    }
                }
                if (iMin != i)
                {
                    DateTime temp = dates[i];
                    dates[i] = dates[iMin];
                    dates[iMin] = temp;
                }
            }

                Console.Write(string.Join(", ", dates));

        }
    }
}
