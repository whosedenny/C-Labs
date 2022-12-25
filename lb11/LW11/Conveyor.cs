using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LW11
{
    public class Conveyor
    {
        public bool DimensionsObtained { get; set; }
        public bool CutOff { get; set; }
        public bool Sharpened { get; set; }
        public bool ThreadIsCut { get; set; }
        public bool Drilled { get; set; }
        public bool Painted { get; set; }
        public bool Tested { get; set; }
        public bool Packed { get; set; }

        public Conveyor()
        {
            DimensionsObtained = false;
            CutOff = false;
            Sharpened = false;
            ThreadIsCut = false;
            Drilled = false;
            Painted = false;
            Tested = false;
            Packed = false;
        }

        public void Show()
        {
            Console.WriteLine("DimensionsObtained = " + DimensionsObtained);
            Console.WriteLine("CutOff = " + CutOff);
            Console.WriteLine("Sharpened = " + Sharpened);
            Console.WriteLine("ThreadIsCut = " + ThreadIsCut);
            Console.WriteLine("Drilled = " + Drilled);
            Console.WriteLine("Painted = " + Painted);
            Console.WriteLine("Tested = " + Tested);
            Console.WriteLine("Packed = " + Packed);
        }

        public void GetDimensions(Conveyor conveyor) => conveyor.DimensionsObtained = true;
        public void ToCutOff(Conveyor conveyor) => conveyor.CutOff = true;
        public void ToSharpen (Conveyor conveyor) => conveyor.Sharpened = true;
        public void CutThread (Conveyor conveyor) => conveyor.ThreadIsCut = true;
        public void ToDrill (Conveyor conveyor) => conveyor.Drilled = true;
        public void Paint (Conveyor conveyor) => conveyor.Painted = true;
        public void Protest (Conveyor conveyor) => conveyor.Tested = true;
        public void PackUp (Conveyor conveyor) => conveyor.Packed = true;
    }
}
