using System;

namespace Auto_ohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Auto-ohjelma!");
            Car MyCar = new Car();
            MyCar.AskData();
            MyCar.ShowCarInfo();
            MyCar.Accelerate();
            MyCar.Brake();

            Car My2ndCar = new Car();
            My2ndCar.AskData();
            My2ndCar.ShowCarInfo();
            My2ndCar.Accelerate();
            MyCar.Brake();
        }
    }
}
