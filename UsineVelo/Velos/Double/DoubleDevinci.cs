using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsineVelo.Velos.Double
{
    public class DoubleDevinci : IDouble
    {
        public void FabriquerCadre()
        {
            Console.WriteLine("Je fabrique un cadre qui craque");
        }

        public void FabriquerRoue()
        {
            Console.WriteLine("Je fabrique des roue de devinci");
        }
    }
}
