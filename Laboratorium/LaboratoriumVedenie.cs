using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium
{
    partial class Laboratorium
    {
        class VeduciLaboratoria
        {
            string meno;
            string priezvisko;
            public VeduciLaboratoria(string meno, string priezvisko)
            {
                this.meno = meno;
                this.priezvisko = priezvisko;
            }
            public string VypisMeno()
            {
                return string.Format("{0} {1}", meno, priezvisko);
                // Console.WriteLine("Meno veduceho je:{0}+{1}", meno, priezvisko);
            }
            
            
        }
    }
}
