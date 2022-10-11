/*
 * Inspiré de Côté J. (2022) AbstractFactory (Version 1.0) [Code source].
 * 
 * Alexandre Ouellet - 2022
 */
using UsineVelo.Velos;

namespace UsineVelo.Usines
{
    public abstract class UsineAbstraite
    {
        public UsineAbstraite(string nom, string description)
        {
            Nom = nom;
            Description = description;
        }

        protected string Nom;
        protected string Description;

        public abstract MonteurVeloAbstrait GetRecetteDoubleSupsension();

        public abstract MonteurVeloAbstrait GetRecetteSimpleSuspension();

        public virtual void AfficherInformationUsine()
        {
            Console.WriteLine($"{Nom} | {Description}");
        }
    }
}
