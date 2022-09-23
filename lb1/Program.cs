using System;
namespace lb1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double R, R_1, R_2;
                bool flag = false;
                do
                {
                    Console.WriteLine("Введите значение первого резистора ");
                    flag = double.TryParse(Console.ReadLine(), out R_1);
                } while (R_1 <= 0 || !flag);
                flag = false;
                do
                {
                    Console.WriteLine("Введите значение второго резистора: ");
                    flag = double.TryParse(Console.ReadLine(), out R_2);
                } while (R_2 <= 0 || !flag);

                R = (1 / R_1) + (1 / R_2);
                Console.WriteLine("ОТВЕТ: " + R);
                Console.ReadLine();
            }
        }
    }
}