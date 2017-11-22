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

            Console.WriteLine("hggd {0}", odstredivka1.VypisInformacieOPristroji());         
        }
        
    }
}
