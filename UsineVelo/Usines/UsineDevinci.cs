/*
 * Inspiré de Côté J. (2022) AbstractFactory (Version 1.0) [Code source].
 * 
 * Alexandre Ouellet - 2022
 */
using UsineVelo.Velos;

namespace UsineVelo.Usines
{
    public class UsineDevinci : UsineAbstraite
    {
        public UsineDevinci() : base("Devinci", "Cycles Devinci is a Canadian bicycle manufacturer established in Chicoutimi, Quebec in 1987. In addition to a full line of road, mountain and hybrid bicycles, it also manufactures the BIXI-brand of bicycle used in bicycle sharing schemes in cities such as Montreal and Toronto.")
        {           
        }

        public override MonteurVeloAbstrait GetRecetteDoubleSupsension()
        {
            return new MonteurDoubleDevinci();     
        }

        public override MonteurVeloAbstrait GetRecetteSimpleSuspension()
        {
            return new MonteurSimpleDevinci();
        }
    }
}
