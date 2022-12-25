using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW8_2
{
    public class ButtonsPhone : RotaryPhone
    {
        public ButtonsPhone() : base()
        {
            symbols.Add('*');
            symbols.Add('#');
        }

        public override void AcceptCall()
        {
            Console.WriteLine("Ви прийняли дзвінок від 12345678");
        }
    }
}
