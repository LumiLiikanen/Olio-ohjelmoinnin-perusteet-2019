using System;

namespace työntekijä_ohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Työntekijä-ohjelma!");
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Employee[] employees = new Employee[3];
            employees [0] = new Employee("Puuha Pete", "00001", "Ryöukko", 3000);
            employees [1] = new Employee("Mikko Mallikas", "00002", "insinööri", 4000);
            employees [2] = new Employee("Lumi Liikanen", "00003", "Ylijohtaja", 50000);
            foreach (Employee item in employees)
            {
                Console.WriteLine(item.PrintEmployeeInfo());
            }
            employees[0].CompareSalary(employees[1], employees[2]);
        }
    }
}
