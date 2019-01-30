using System;
using System.Collections.Generic;
using System.Text;

namespace työntekijä_ohjelma
{
    class Employee
    {
        string name;
        string id;
        string position;
        int salary;

        public Employee (string name, string id, string position, int salary)
        {
            this.name = name;
            this.id = id;
            this.position = position;
            this.salary = salary;
        }

        public string PrintEmployeeInfo()
        {
            string text = $"Työntekijä {this.name}\nId {this.id}\nTehtävä {this.position}\nPalkka {this.salary}€\n--------------------------------------------------------------\n\n";
            return text;
        }

        public void CompareSalary (Employee x, Employee y)
        {

            if (this.salary > x.salary)
                Console.WriteLine($"{this.name} palkka {this.salary}€ on suurempi kuin {x.name} palkka {x.salary}€.");
            else if (this.salary < x.salary)
                Console.WriteLine($"{this.name} palkka {this.salary}€ on pienempi kuin {x.name} palkka {x.salary}€.");
            else
                Console.WriteLine($"{this.name} palkka {this.salary}€ on sama kuin {x.name} palkka {x.salary}€.");

            if (this.salary > y.salary)
                Console.WriteLine($"{this.name} palkka {this.salary}€ on suurempi kuin {y.name} palkka {y.salary}€.");
            else if (this.salary < y.salary)
                Console.WriteLine($"{this.name} palkka {this.salary}€ on pienempi kuin {y.name} palkka {y.salary}€.");
            else
                Console.WriteLine($"{this.name} palkka {this.salary}€ on sama kuin {y.name} palkka {y.salary}€.");

            if (x.salary > y.salary)
                Console.WriteLine($"{x.name} palkka {x.salary}€ on suurempi kuin {y.name} palkka {y.salary}€.");
            else if (x.salary < y.salary)
                Console.WriteLine($"{x.name} palkka {x.salary}€ on pienempi kuin {y.name} palkka {y.salary}€.");
            else
                Console.WriteLine($"{x.name} palkka {x.salary}€ on sama kuin {y.name} palkka {y.salary}€.");
        }
    }
}
