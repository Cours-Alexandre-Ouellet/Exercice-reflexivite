/*
 * Inspiré de Côté J. (2022) AbstractFactory (Version 1.0) [Code source].
 * 
 * Alexandre Ouellet - 2022
 */

namespace UsineVelo.Velos
{
    public class MonteurDoubleDevinci : MonteurVeloAbstrait
    {
        public MonteurDoubleDevinci() : base("Devinci", "Double")
        {
            
        }

        protected override MonteurVeloAbstrait FabriquerFreins()
        {
            velo.FreinsADisques = true;
            return this;
        }

        protected override MonteurVeloAbstrait FabriquerPeinture()
        {
            velo.Couleur = "Jaune";
            return this;
        }

        protected override MonteurVeloAbstrait FabriquerRoue()
        {
            velo.DiametreRoue = 13.5f;
            return this;
        }
    }
}
