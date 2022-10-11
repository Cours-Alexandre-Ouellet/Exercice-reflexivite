using UsineVelo.Velos.Double;

namespace UsineVelo.Usines
{
    public class UsineTrek : UsineAbstraite
    {
        public UsineTrek() : base("Trek", "Trek started in a small Wisconsin barn in 1976, but our founders always saw something bigger. Forty-four years later, we're on a mission to ...")
        {
        }

        public override IDouble GetRecetteDoubleSupsension()
        {
            return new DoubleTrek();
        }
    }
}
