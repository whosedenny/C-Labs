using System;

namespace lb2
{
    class Program
    {
        static void Main(string[] args)
        {
            double i, n, k, a;
            bool flag = false;
            a = 0;
            do
            {
                Console.WriteLine("Введите n: ");
                flag = double.TryParse(Console.ReadLine(), out n);
            } while (!flag);
            k = n * n;
            for (i = k; i <= n * k; i++)
            {
                a += (Math.Pow(k, 2) - 1) / (Math.Pow((-1), (k + 1)) * Math.Pow(k, 2) + 7);
            }
            Console.WriteLine("ОТВЕТ: " + a);
        }
    }
}