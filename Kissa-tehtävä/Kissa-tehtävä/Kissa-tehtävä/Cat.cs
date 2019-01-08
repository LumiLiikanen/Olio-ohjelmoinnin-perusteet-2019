using System;
using System.Collections.Generic;
using System.Text;

namespace Kissa_tehtävä
{
    class Cat
    {
        public string name;
        public int weight;

        public Cat(string name, int weightValue)
        {
            this.name = name;
            this.weight = weightValue;
            Console.WriteLine($"Luotu kissa {this.name}");
        }
        public Cat(int weightValue)
        {
            this.weight = weightValue;
        }
        public void increaseweight(int value)
        {
            this.weight += value;
        }
        public void PrintWeight()
        {
            Console.WriteLine($"Kissan {this.name} uusi paino on {this.weight}");
        }
    }
}
