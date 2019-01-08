using System;

namespace Kissa_tehtävä
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kissaohjelma");
            Cat MyFirstCat = new Cat("Heiskanen", 1);
            MyFirstCat.increaseweight(1);
            MyFirstCat.PrintWeight();
        }
    }
}
