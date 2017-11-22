using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium
{
    sealed class Mikroskop : Pristroj, IOvladaniePristroja
    {
        string vyrobneCislo;
        string typZariadenia;
        public Mikroskop(string vyrobneCislo, string typZariadenia)
        {
            this.vyrobneCislo = vyrobneCislo;
            this.typZariadenia = typZariadenia;
        }

        public override void VypisInformacieOPristroji()
        {
            Console.WriteLine("Vyrobne cislo je: {0}", vyrobneCislo);
        }
        public override void VypisDetailneInformacie()
        {
            Console.WriteLine("Som Mikroskop typu: {0}", typZariadenia);
        }
        public void Zapni()
        {
            Console.WriteLine("Mikroskop je zapnuty");
        }
        public void Vypni()
        {
            Console.WriteLine("Mikroskop je vypnuty");
        }
    }
}
