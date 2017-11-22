using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium
{
     sealed class Odstredivka : Pristroj, IOvladaniePristroja
    {
        string vyrobneCislo;
        string typZariadenia;
        public Odstredivka(string vyrobneCislo, string typZariadenia)
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
            Console.WriteLine("Som Odstredivka typu: {0}", typZariadenia);
        }
        public void Zapni()
        {
            Console.WriteLine("Odstredivka je zapnuta");
        }
        public void Vypni()
        {
            Console.WriteLine("Odstredivka je vypnuta");
        }
        
    }
}
