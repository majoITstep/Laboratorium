using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium
{
    partial class Laboratorium
    {
        public Pristroj LaboratorniPristroj1;
        public Pristroj LaboratorniPristroj2;

        public void SpustVyskum()
        {
            Veduci veduci = new Veduci("Mgr");
            LaboratorniPristroj1 = new Mikroskop();
            LaboratorniPristroj2 = new Odstredivka();
            LaboratorniPristroj1.Nazov = "MO301";
            LaboratorniPristroj2.Nazov = "OP1000";
            IOvladaniePristroja ovladanie = (IOvladaniePristroja)LaboratorniPristroj1;
            ovladanie.Zapni();

            LaboratorniPristroj1.VypisDetailneInformacie();
            LaboratorniPristroj2.VypisDetailneInformacie();
            
        }
          
    }
}
