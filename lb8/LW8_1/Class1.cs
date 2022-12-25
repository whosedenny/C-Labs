using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LW8_1
{
    public class Car
    {
        public string Model;
        public string Color;
        public int Speed;
        public int Age;

        public Car()
        {
            bool flag = false;
            Console.WriteLine("модель: ");
            Model = Console.ReadLine();
            Console.WriteLine("Color: ");
            Color = Console.ReadLine();
            int speed;
            do{
                Console.WriteLine("Speed: ");
                flag = Int32.TryParse(Console.ReadLine(), out speed);
            } while (!(flag));
            Speed = speed;
            int age;
            do{
                Console.WriteLine("Age: ");
                flag = Int32.TryParse(Console.ReadLine(), out age);
            } while (!(flag));
            Age = age;
        }

        public Car(string model, string color, int speed, int age)
        {
            Model = model;
            Color = color;
            Speed = speed;
            Age = age;
        }
    }

    public static class Garage
    {
        static private List<Car> cars = new List<Car>();

        static public void LetsRide()
        {
            Console.WriteLine("Which car do you want to drive?");
            Ride(Choose());
        }

        static public void AddNewCar(Car car)
        {
            cars.Add(car);
        }

        static public void RemoveCar()
        {
            Console.WriteLine("What car do you want to remove?");
            Remove(Choose());
        }

        static private void Remove(Car car)
        {
            if (car == null)return;
            Console.WriteLine("you removed a " + car.Model + " , with " + car.Color + " color, " + car.Age + " ages and at a speed of " + car.Speed + " kilometers per hour.");
            cars.Remove(car);
        }

        static private void Ride(Car car)
        {
            if (car == null) return;
            Console.WriteLine("You were driving a " + car.Model + " , with " + car.Color + " color, " + car.Age + " ages and at a speed of " + car.Speed + " kilometers per hour.");
        }

        static private Car Choose()
        {
            Console.WriteLine("Enter parameters: ");
            string prop = Console.ReadLine();
            List<Car> sc = Search(prop.Split(' '));
            if (sc.Count == 0)
            {
                Console.WriteLine("You don't have such a car.");
                return null;
            }
            for (int i = 0; i < sc.Count; i++) Console.WriteLine($"[{i + 1}] " + sc[i].Model + " , with " + sc[i].Color + " color, " + sc[i].Age + " ages and at a speed of " + sc[i].Speed + " kilometers per hour.");
            Console.WriteLine("Choose you car: ");
            int userChoise;
            bool flag = false;
            do
            {
                flag = Int32.TryParse(Console.ReadLine(), out userChoise);
            } while (!flag && userChoise <= sc.Count);
            return sc[userChoise - 1];
        }

        static private List<Car> Search(string[] param)
        {
            List<Car> sc = new List<Car> { };
            bool flag = false;
            for (int i = 0; i < cars.Count(); i++)
            {
                for (int j = 0; j < param.Length; j++)
                {
                    if (param[j] == cars[i].Model || param[j] == Convert.ToString(cars[i].Speed) || param[j] == cars[i].Color || param[j] == Convert.ToString(cars[i].Age))
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag) sc.Add(cars[i]);
            }
            return sc;
        }
    }
}
