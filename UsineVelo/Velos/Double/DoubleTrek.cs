using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsineVelo.Usines;

namespace UsineVelo.Velos.Double
{
    public class DoubleTrek : IDouble
    {
        public void FabriquerRoue()
        {
            Console.WriteLine("Fabrication de roue TREK en cours");
        }
        public void FabriquerCadre()
        {
            Console.WriteLine("Je ne fais pas de cadre de double suspension.");
            
        }
    }
}
