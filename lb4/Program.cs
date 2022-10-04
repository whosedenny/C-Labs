using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb4
{
    class Program
    {
 
        static void Main(string[] args)
        {
            int mostOtenNumber = 0;
            int highestNumberOfRepetitions = 0;
            int numberOfRepetitions = 0;
            Console.Write("Введите длинну массива: ");

            int[] arr = new int[int.Parse(Console.ReadLine())];


            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Введите " + i + " элемент массива = ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            foreach (int i in arr)
            {
                foreach (int j in arr)
                {
                    if (i == j)
                    {
                        numberOfRepetitions++;
                    }
                }

                if (highestNumberOfRepetitions < numberOfRepetitions)
                {
                    highestNumberOfRepetitions = numberOfRepetitions;
                    mostOtenNumber = i;
                }
                numberOfRepetitions = 0;
            }
            Console.WriteLine("Больше всего повторяется число {0}, количество его повторений равно {1}", mostOtenNumber, highestNumberOfRepetitions);
            Console.ReadKey(true);
        }
    }
}