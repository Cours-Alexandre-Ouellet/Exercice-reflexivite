namespace UsineVelo.Velos
{
    public class MonteurSimpleDevinci : MonteurVeloAbstrait
    {
        public MonteurSimpleDevinci() : base("Devinci", "Simple")
        {

        }

        protected override MonteurVeloAbstrait FabriquerFreins()
        {
            velo.FreinsADisques = true;
            return this;
        }

        protected override MonteurVeloAbstrait FabriquerPeinture()
        {
            velo.Couleur = "Verte";
            return this;
        }

        protected override MonteurVeloAbstrait FabriquerRoue()
        {
            velo.DiametreRoue = 14.8f;
            return this;
        }
    }
}
