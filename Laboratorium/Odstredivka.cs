using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium
{
     sealed class Odstredivka : Pristroj, IOvladaniePristroja
    {
        
        public override void VypisDetailneInformacie()
        {
            base.VypisInformacieOPristroji();
            Console.WriteLine("Som Odstredivka");
            base.VypisStav();

        }
        public void Zapni()
        {
            zapnute = true;
        }
        public void Vypni()
        {
            zapnute = false;
        }

    }
}
