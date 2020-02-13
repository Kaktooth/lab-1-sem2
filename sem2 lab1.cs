using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication33
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Введіть розмірність масиву");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            array = RandomEnter(array);
            array = Sorting(array);
            array = MultiplyNums(array);
            sum = ArraySum(array, sum);
        
            Console.WriteLine("Сума квадратів: {0}", sum);

        }

        static int[] Sorting(int[] array)
        {
            for (int j = 2; array[j] <= array.Length; j++)
            {
                int i = j - 1;
                int key = array[j];
                while (i > 0 && array[i] > key)
                {
                    i = i - 1;
                }
                array[i + 1] = key;
            }
            return array;
        }
        static int[] RandomEnter(int[] array)
        {
            Random random = new Random();
            for (int i = 0; array.Length > i; i++)
            {
                array[i] = random.Next(-50, 50);

            }
            return array;
        }

        static int[] MultiplyNums(int[] array)
        {

            for (int j = 0; array[j] < array.Length; j++)
            {

                if (j % 2 != 0)
                {
                    array[j] = array[j] * array[j];

                }


            }
            return array;
        }
        static int ArraySum(int[] array,int sum)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {

                    sum += array[i];
                }

            }
            return sum;
        }

    }
}