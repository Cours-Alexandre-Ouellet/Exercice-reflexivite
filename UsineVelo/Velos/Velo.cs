namespace UsineVelo.Velos
{
    public class Velo
    {
        public string Compagnie { get; internal set; }

        public string TypeSuspension { get; internal set; }

        public float DiametreRoue { get; internal set; }

        public bool FreinsADisques { get; internal set; }

        public string Couleur { get; internal set; }

        public string AfficherVelo()
        {
            return $"Velo de {Compagnie} avec une suspension {TypeSuspension}. Le diametre des roues" +
                $"est de {DiametreRoue} et de couleur {Couleur}. Il possede des freins {(FreinsADisques ? "a disques" : "a patins")}.";
        }
    }
}