using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb5
{
    // Дана квадратна матриця порядку M. Замінити нулями елементи матриці,
    // що лежать 1) нижче 2) вище 3) головної; 4) побічної діагоналі.

    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = {
                  { 1, 2, 3, 4 },
                  { 5, 6, 7, 8 },
                 { 9, 10, 11, 12 },
                { 13, 14, 15, 16 },
            };

            Console.WriteLine("Введите где вы хотите 0 (введите цифру \n1) ниже \n2) выше");
            string aboveOrBelow = Console.ReadLine();

            Console.WriteLine("Введите какую диагональ (введите цифру) \n1) главная \n2) побочная");
            string mainOrSide = Console.ReadLine();

            int size = mat.GetUpperBound(0) + 1;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {

                    if (mainOrSide.Equals("1"))
                    {
                        if (aboveOrBelow.Equals("1"))
                        {
                            if (i > j)
                            {
                                Console.Write(0 + " ");
                            }
                            else
                            {
                                Console.Write(mat[i, j] + " ");
                            }
                        }
                        else if (aboveOrBelow.Equals("2"))
                        {

                            if (i < j)
                            {
                                Console.Write(0 + " ");
                            }
                            else
                            {
                                Console.Write(mat[i, j] + " ");
                            }
                        }

                    }
                    else
                    {
                        if (aboveOrBelow.Equals("1"))
                        {
                            if (i + j > size - 1)
                            {
                                Console.Write(0 + " ");
                            }
                            else
                            {
                                Console.Write(mat[i, j] + " ");
                            }
                        }
                        else if (aboveOrBelow.Equals("2"))
                        {

                            if (i + j < size - 1)
                            {
                                Console.Write(0 + " ");
                            }
                            else
                            {
                                Console.Write(mat[i, j] + " ");
                            }
                        }
                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
