/*
 * Inspiré de Côté J. (2022) AbstractFactory (Version 1.0) [Code source].
 * 
 * Alexandre Ouellet - 2022
 */

namespace UsineVelo.Velos
{
    public abstract class MonteurVeloAbstrait
    {
        protected readonly Velo velo;

        public MonteurVeloAbstrait(string compagnie, string typeSuspension)
        {
            velo = new Velo { Compagnie = compagnie, TypeSuspension = typeSuspension};
        }

        public virtual Velo FabriquerVelo()
        {
            // Chaîne des appels par défaut
            FabriquerRoue().FabriquerFreins().FabriquerPeinture();

            return velo;
        }

        protected abstract MonteurVeloAbstrait FabriquerRoue();

        protected abstract MonteurVeloAbstrait FabriquerFreins();

        protected abstract MonteurVeloAbstrait FabriquerPeinture();
    }
}
