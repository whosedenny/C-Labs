using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW8_2
{
    public class BlackScreenPhone : ButtonsPhone
    {
        internal string ScreenResolution;
        internal string ScreenSize;
        public string Color;

        public BlackScreenPhone() : base()
        {
            symbols.Add('a');
            symbols.Add('b');
            symbols.Add('c');
            symbols.Add('d');
            symbols.Add('e');
            //...
            Console.WriteLine("Введіть роздільну здатність екрану: ");
            ScreenResolution = Console.ReadLine();
            Console.WriteLine("Введіть розмір: ");
            ScreenSize = Console.ReadLine();
            Console.WriteLine("Введіть колір: ");
            Color = Console.ReadLine();
        }
        public virtual void SendSms()
        {
            Console.Write("Введіть смс, яке хочете відправити до 12345678 :");
            string message = Console.ReadLine();
        }

        public virtual void AcceptSms()
        {
            Console.WriteLine("Ви отримали повідомлення від 12345678: Привіт!");
        }
    }
}
