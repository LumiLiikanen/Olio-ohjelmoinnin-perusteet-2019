using System;

namespace Kirja_ohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirja ohjelma!");
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Book MyBook = new Book("Mahtava", "Lumi Liikanen", "00101", 20.00M);
            Book my2ndBook = new Book("Mahtava2", "Lumi Liikanen", "00102", 28.00M);

            Console.WriteLine(MyBook.Compare(my2ndBook));
        }
    }
}
