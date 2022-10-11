using UsineVelo.Velos.Double;

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

        public abstract IDouble GetRecetteDoubleSupsension();

        public virtual void AfficherInformationUsine()
        {
            Console.WriteLine($"{Nom} | {Description}");
        }
    }
}
