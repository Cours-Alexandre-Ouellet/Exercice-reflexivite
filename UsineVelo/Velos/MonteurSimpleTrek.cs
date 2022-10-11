namespace UsineVelo.Velos
{
    public class MonteurSimpleTrek : MonteurVeloAbstrait
    {
        public MonteurSimpleTrek() : base("Trek", "Simple")
        {

        }
        
        protected override MonteurVeloAbstrait FabriquerFreins()
        {
            velo.FreinsADisques = false;
            return this;
        }

        protected override MonteurVeloAbstrait FabriquerPeinture()
        {
            velo.Couleur = "bleue";
            return this;
        }

        protected override MonteurVeloAbstrait FabriquerRoue()
        {
            velo.DiametreRoue = 13.5f;
            return this;
        }
    }
}
