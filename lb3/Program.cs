using System;
namespace lb3
{
    class Program
    {
        static void Main(string[] args)
        {
            int f, s, t;
            bool flag = false;
            do
            {
                Console.WriteLine("Введіть перше число: ");
                flag = int.TryParse(Console.ReadLine(), out f);
            } while (f <= 0 || !flag);
            flag = false;
            do
            {
                Console.WriteLine("Введіть друге число: ");
                flag = int.TryParse(Console.ReadLine(), out s);
            } while (s <= 0 || !flag);
            flag = false;
            do
            {
                Console.WriteLine("Введіть третє число: ");
                flag = int.TryParse(Console.ReadLine(), out t);
            } while (t <= 0 || !flag);

            if (f == s || s== t || t == f)
            {
                Console.WriteLine("Серед цих трьох цілих чисел є хоча б одна пара співпадаючих.");
            }
            else
            {
                Console.WriteLine("Серед цих трьох цілих чисел немає хоча б одної пара співпадаючих.");
            }
        }
    }
}
