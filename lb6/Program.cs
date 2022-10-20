using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb6
{
    class Program
    {
        static void Main(string[] args)
        {
            Reverse(1234);
            Reverse("ABC");
            Reverse(123.456);
            Reverse("АБВ,ГДЕ", ",");

            int[] s = Reverse(new int[] { 1,2,3 });
     
            foreach(var i in s)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            Change(ref s, 5);

            foreach (var i in s)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();
        }

        static void Reverse(int i)
        {
            int b = i;
            string result = "";
            while (i != 0)
            {
                result += i % 10;
                i /= 10;
            }

            Console.WriteLine(b + "->" + result);
        }

        static void Reverse(string i)
        {
            char[] arr = i.ToCharArray();
            Array.Reverse(arr);

            Console.WriteLine(i + "->" + new string(arr));
        }

        static void Reverse(double i)
        {
           
            string[] arr = i.ToString().Split(',');
            string r = "";

            int temp;

            for (int j = 0; j < arr.Length; j++)
            {
                temp = int.Parse(arr[j]);
                while (temp != 0)
                {
                    r += temp % 10;
                    temp /= 10;
                }

                r += ",";
            }

            Console.WriteLine(i + "->" + r.Substring(0, r.Length - 1)); 
        }

        static void Reverse(string i, string symb)
        {
            string[] arr = i.Split(symb.ToCharArray());
            string r = "";

            for (int j = 0; j < arr.Length; j++)
            {
                char[] arr1 = arr[j].ToCharArray();
                Array.Reverse(arr1);

                r += new string(arr1) + symb;
            }


            Console.WriteLine(r.Remove(r.Length-1));
        }

        static int[] Reverse(int [] s)
        {
            int[] res = new int[s.Length];

            for (int j = 0, i = s.Length - 1; i > -1; i--, j++)
            {
             
                res[j] = (int)s[i];
            }

            return res;
        }


        static void Change(ref int [] arr, int size)
        {
            int[] newA = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                newA[i] = arr[i]; 
            }

            arr = newA;
        }
    }
}
