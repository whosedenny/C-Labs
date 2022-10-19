using System;

namespace lb3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 469  q1 = 6 / 4; q2 = 9 / 6;  q1 == q2
            int n;
            do
            {
                Console.WriteLine("Введите трехзначное число: ");
                n = int.Parse(Console.ReadLine());

                if (99 < n && n < 1000)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели не трехзначное число!");
                }
            } while (true);

            char[] s = n.ToString().ToCharArray();

            if (int.Parse(s[1].ToString()) / (double)int.Parse(s[0].ToString()) == int.Parse(s[2].ToString()) / (double)int.Parse(s[1].ToString()))
            {
                Console.WriteLine("True");
            }

            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
