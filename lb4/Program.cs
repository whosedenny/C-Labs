using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb4
{
    // Даний масив розміру N. Визначити кількість його проміжків монотонності.
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 3, 2, 3, 5, 6, 6, 4 };

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i > 1)
                {
                    if ((arr[i] > arr[i - 1]) && (arr[i - 1] < arr[i - 2]))
                    {
                        count++;
                    }
                    else if ((arr[i] < arr[i - 1]) && (arr[i - 1] > arr[i - 2]))
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("Кiлькiсть  промiжкiв  монотонностi якi зростають - {0}", count);
            Console.ReadLine();
        }
    }
}
