using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb7
{
    class Program
    {
        static void Main(string[] args)
        {
            //.Створити ліст інтових змінних, дозволити можливість заповнення з калвіатури.
            //Вивести індекси змінних рівних перевірочній(теж ввести з клавіатури). Скопіювати ліст в масив.


            List<int> vs = new List<int>();

            Console.WriteLine("Сколько элементов вы хотите? ");
            int c = int.Parse(Console.ReadLine());

            for (int i = 0; i < c; i++)
            {
                Console.WriteLine("Введите {0} елемент", i);
                vs.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Введите проверочное число");

            int numb = int.Parse(Console.ReadLine());

            Console.Write("Индексы: ");
            for (int j = 0; j < vs.Count; j++)
            {
                if(vs[j] == numb)
                {
                    Console.Write(j + " ");
                }
            }

            int[] arr = new int[vs.Count];

            for (int i = 0; i < vs.Count; i++)
            {
                arr[i] = vs[i];
            }

            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.Read();
        }
    }
}
