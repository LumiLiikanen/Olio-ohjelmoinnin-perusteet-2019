using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Kirja_ohjelma
{
    class Book
    {
        public string title;
        public string author;
        public string id;
        public decimal price;

        public Book(string title, string author, string id, decimal price)
        {
            this.title = title;
            this.author = author;
            this.id = id;
            this.price = price;
            Console.WriteLine($"Kirjan nimi on {this.title}.\nKirjan on kirjoittanut {this.author}.\nKirjan id-numero {this.id}.\nKirjan hinta {this.price.ToString("c",CultureInfo.CurrentCulture)}.");
        }
        public string Compare(Book my2ndBook)
        {
            string text = string.Empty;
            if (this.price > my2ndBook.price)
                text = $"{this.title} on kalliimpi kuin {my2ndBook.title}";
            else
                text = $"{my2ndBook.title} on kalliimpi kuin {this.title}";
            return text;
        }
    }
}
