using System;

namespace lb5
{
    class Program
    {
        static int Check(out int countmass)
        {
            try
            {
                countmass = int.Parse(Console.ReadLine());
                return countmass;
            }
            catch (FormatException)
            {
                return Check(out countmass);
            }
        }
        static void Main(string[] args)
        {
            int n, m;
            Console.WriteLine("Скільки рядків бажаєте?");
            Check(out n);
            Console.WriteLine("Скільки стовбців бажаєте?");
            Check(out m);
            int number;
            Console.WriteLine("Введіть число для пошуку");
            Check(out number);
            int[,] mas = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"Введіть {i + 1}:{j + 1}");
                    Check(out mas[i, j]);
                }
            }
            Console.WriteLine("Масив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int minS = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (number == mas[i, j])
                    {
                        minS = i;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Інший масив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i != minS)
                    {
                        Console.Write(mas[i, j] + "\t");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}