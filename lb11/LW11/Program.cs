using System;

namespace LW11;

public delegate void Delegate(Conveyor conveyor);

class Program
{
    static void Main(string[] args)
    {
        Conveyor conveyor1 = new Conveyor();

        Delegate FewMetods = new(conveyor1.GetDimensions);
        FewMetods += conveyor1.ToCutOff;
        FewMetods(conveyor1);

        conveyor1.Show();

        Console.WriteLine("\n--------------------------------\n");

        Conveyor conveyor2 = new Conveyor();

        Delegate HalfOfMetods = new(conveyor2.GetDimensions);
        HalfOfMetods += conveyor2.ToCutOff;
        HalfOfMetods += conveyor2.ToSharpen;
        HalfOfMetods += conveyor2.CutThread;
        HalfOfMetods(conveyor2);

        conveyor2.Show();

        Console.WriteLine("\n--------------------------------\n");

        Conveyor conveyor3 = new Conveyor();

        Delegate AllOfMetods = new(conveyor3.GetDimensions);
        AllOfMetods += conveyor3.ToCutOff;
        AllOfMetods += conveyor3.ToSharpen;
        AllOfMetods += conveyor3.CutThread;
        AllOfMetods(conveyor3);

        conveyor3.Show();
    }
}