/*
 * Inspiré de Côté J. (2022) AbstractFactory (Version 1.0) [Code source].
 * 
 * Alexandre Ouellet - 2022
 */
using UsineVelo.Velos;

namespace UsineVelo.Usines
{
    public class UsineTrek : UsineAbstraite
    {
        public UsineTrek() : base("Trek", "Trek started in a small Wisconsin barn in 1976, but our founders always saw something bigger. Forty-four years later, we're on a mission to ...")
        {
        }

        public override MonteurVeloAbstrait GetRecetteDoubleSupsension()
        {
            return new MonteurDoubleTrek();
        }

        public override MonteurVeloAbstrait GetRecetteSimpleSuspension()
        {
            return new MonteurSimpleTrek();
        }
    }
}
