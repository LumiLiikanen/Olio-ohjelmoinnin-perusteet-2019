using System;
using System.Collections.Generic;
using System.Text;

namespace Auto_ohjelma
{
    class Car
    {
        public string brand;
        public int speed;
        int accelerated;

        public void AskData()
        {
            Console.WriteLine("Syötä auton merkki:");
            brand = Console.ReadLine();
            Console.WriteLine("Syötä auton nopeus:");
            speed = int.Parse(Console.ReadLine());
        }

        public string ShowCarInfo()
        {
            Console.WriteLine($"Auton merkki on {brand}\nNopeus {speed}");
            return Console.ReadLine();
        }
        public void Accelerate()
        {
            Console.WriteLine("Paljon haluat lisätä nopeutta?");
            string NewSpeed = Console.ReadLine();
            int ispeed = int.Parse(NewSpeed);
            this.accelerated = speed + ispeed;
            if (ispeed > 0)
            Console.WriteLine($"Auton uusi nopeus on {this.accelerated}!");
            else
            Console.WriteLine("Negatiivista muutosta ei sallita!");
        }
        public void Brake()
        {
            Console.WriteLine($"Vauhtia jarruteltiin 10%, uusi nopeutesi on {this.accelerated*0.9}");
        }
    }
}
