using System;
using System.Collections.Generic;
using System.Text;

namespace Firma_ohjelma
{
    class Company
    {
        public string title;
        public string address;
        public int phone;
        public int outcome;
        public int expence;

        public Company()
        {
            this.title = "";
            this.address = "";
            this.phone = 0;
            this.outcome = 0;
            this.expence = 0;
        }
        public Company(string title, string address, int phone, int outcome, int expence)
        {
            this.title = title;
            this.address = address;
            this.phone = phone;
            this.outcome = outcome;
            this.expence = expence;
        }
        public Company(Company CopyCompany)
        {
            title = CopyCompany.title;
            address = CopyCompany.address;
            phone = CopyCompany.phone;
            outcome = CopyCompany.outcome;
            expence = CopyCompany.expence;
        }
        public string Profit()
        {
            double profitpercentage = ((outcome - expence) / expence )* 100;
            string text = "";

            if (profitpercentage < 100)
                text = "Ei hyvin mene.";
            else if (profitpercentage <= 200)
                text = "Voisi mennä paremmin.";
            else if (profitpercentage <= 300)
                text = "Menettelee.";
            else
                text = "Nyt menee hyvin!";
            return $"Voittoprosenttisi on {profitpercentage}% {text}";
        }
        public override string ToString()
        {
            return $"{this.title}\n{this.address}\n{this.phone}\n{this.outcome}€\n{this.expence}€";
        }

    }
}
