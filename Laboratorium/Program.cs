using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium
{
    class Program
    {
        static void Main(string[] args)
        {
            Pristroj odstredivka1 = new Odstredivka("154/2017", "prietokova");
            odstredivka1.VypisDetailneInformacie();
            odstredivka1.VypisInformacieOPristroji();
            IOvladaniePristroja Z = odstredivka1;
            Z.Zapni();
            Console.ReadLine();

        }
        
    }
}
