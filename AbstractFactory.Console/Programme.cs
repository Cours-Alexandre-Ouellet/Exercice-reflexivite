/* 
 * Alexandre Ouellet - 2022
 */

using UsineVelo.GenerateurUsines;
using UsineVelo.Usines;
using UsineVelo.Velos;
using System.Globalization;

/// <summary>
/// Gestion du programme d'affichage console
/// </summary>
class Programme
{
    static void Main(string[] args)
    {
        try
        {
            Programme programme = new Programme();
            programme.Executer();
        }
        catch(Exception exception)
        {
            Console.WriteLine($"Erreur fatale !\n{exception.Message}");
        }
    }

    private void Executer()
    {
        bool quitter = false;

        while(!quitter)
        {
            string compagnie = SaisirString("De quelle compagnie fabriquer une vélo ? (Devinci / Trek)");
            UsineAbstraite usine = GenerateurUsine.Instance.GenererUsine(compagnie);

            if(usine is null)       // Erreur, donc on recommence
            {
                continue;
            }

            string typeSuspension = SaisirString("Quel type de suspension devrait avoir le vélo ? (Simple / Double)");
            MonteurVeloAbstrait monteurVelo = GetMonteur(usine, typeSuspension);

            if(monteurVelo is null) // Erreur, donc on recommence
            {
                continue;
            }

            Velo velo = monteurVelo.FabriquerVelo();
            PersonnaliserVelo(velo);

            quitter = !SaisirBooleen("Souhaitez-vous entrer un nouveau velo.");

        }
    }

    private void PersonnaliserVelo(Velo velo)
    {
        bool finPersonnalisation = false;
        while(!finPersonnalisation)
        {
            string propriete = SaisirString("Quel attribut voulez-vous personnaliser ? (DiametreRoue, FreinsADisque, Couleur, [vide pour arreter]");

            if(propriete == "") {
                finPersonnalisation = true;
                continue;
            } 
            
            string valeur = SaisirString("Quelle valeur doit prendre cet attribut ?");

            if(ModifierVelo(velo, propriete, valeur))
            {
                Console.WriteLine($"Le velo a ete modifie\n{velo.AfficherVelo()}.");
            }
            else
            {
                Console.WriteLine("Impossible de faire la modification.");
            }
        }
    }

    private MonteurVeloAbstrait GetMonteur(UsineAbstraite usine, string typeSuspension)
    {
        // Exercice 2 - Appeler le bon monteur sur l'usine
    }

    private bool ModifierVelo(Velo velo, string proprieteModifiee, string valeur)
    {
        // Exercice 3 - Modifier la propriété du vélo pour quelle adopte la bonne valeur
        // Exercice 4 - Ajouter des attributs aux champs pour permettre leur validation et pour utiliser une etiquette
        // différente que le nom de la propriete.
    }

    private static string SaisirString(string message)
    {
        Console.WriteLine(message);
        return Console.ReadLine() ?? "";
    }

    private static float SaisirFloat(string message)
    {
        Console.WriteLine(message);
        float valeur;
        while(!float.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out valeur))
        {
            Console.WriteLine("Veuillez saisir un nombre décimal en utilisant le « . » comme séparateur.");
        }
        return valeur;
    }

    private static bool SaisirBooleen(string message)
    {
        Console.WriteLine(message + "(O / N)");
        bool valide = false;
        string valeurEntree;

        do
        {
            valeurEntree = (Console.ReadLine() ?? "").ToUpperInvariant();
            if(valeurEntree == "O" || valeurEntree == "N")
            {
                valide = true;
            }
            else
            {
                Console.WriteLine("Veuillez saisir « O » pour Oui et « N » pour Non.");
            }
        } while(!valide);

        return valeurEntree == "O";
    }
}