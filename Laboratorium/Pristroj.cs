using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium
{
    abstract class Pristroj
    {
       //string VyrobneCislo;

        public virtual void VypisInformacieOPristroji()

        { }

        public abstract void VypisDetailneInformacie();
        
       }
}
