/*
 * Inspiré de Côté J. (2022) AbstractFactory (Version 1.0) [Code source].
 * 
 * Alexandre Ouellet - 2022
 */
using UsineVelo.Usines;

namespace UsineVelo.GenerateurUsines
{
    public class GenerateurUsine
    {
        private static GenerateurUsine instance;
        public static GenerateurUsine Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GenerateurUsine();
                }
                return instance;
            }
        }


        private GenerateurUsine()
        {

        }

        public UsineAbstraite GenererUsine(string nomUsine)
        {
            // Exercice 1 - Générer l'usine en utilisant le bon nom. Assurez-vous de gérer les erreurs.
        }
    }
}
