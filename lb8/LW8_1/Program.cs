using System;

namespace LW8_1;
class Program
{
    static void Main(string[] args)
    {
        Garage.AddNewCar(new Car("Ford", "black", 100, 1111));
        Garage.AddNewCar(new Car("Audi", "green", 300, 2222));
        Garage.AddNewCar(new Car("Porsche", "white", 700, 3333));
        Garage.AddNewCar(new Car());
        Garage.LetsRide();
        Garage.RemoveCar();
    }
}