using System;

namespace Memento
{
    /// <summary>
    /// Classe simulant l'exécution d'un programme.
    /// </summary>
    public class Application
    {
        /// <summary>
        /// Point d'entrée du programme.
        /// </summary>
        /// <param name="args">Inutilisé.</param>
        public static void Main(string[] args)
        {
            Gestionnaire gestionnaire = new();
            
            // Faire quelques manipulations
            gestionnaire.AjouterManipulation(new Manipulation("Ajouter 1 tasse d'eau"));
            gestionnaire.AjouterManipulation(new Manipulation("Amener à ébulition l'eau"));
            gestionnaire.AjouterManipulation(new Manipulation("Ajouter 50 g de potassium pur"));

            // Contenu du chaudron après cette manipulation
            Console.WriteLine(gestionnaire.Chaudron);

            // BOOM !

            gestionnaire.AnnulerDerniereManipulation();

            // Afficher le contenu du chaudron
            Console.WriteLine(gestionnaire.Chaudron);

            // On refait des opérations
            gestionnaire.AjouterManipulation(new Manipulation("Faire macérer la racine de mandragore"));

            // Afficher le contenu du chaudron
            Console.WriteLine(gestionnaire.Chaudron);
        }
    }
}
