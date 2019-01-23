using System;

namespace Firma_ohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Firma-ohjelma!");
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Company company = new Company("SNW", "Yrityskatu 1", 0401231234, 100000, 101);
            Company enterprise = new Company(company);
            Console.WriteLine(company.ToString());
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine(company.Profit());
        }
    }
}
