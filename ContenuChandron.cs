using System.Collections.Generic;

namespace Memento
{
    /// <summary>
    /// Classe qui contient une copie du contenu du chaudron.
    /// </summary>
    public class ContenuChandron
    {
        /// <summary>
        /// Liste des manipulations effectuées dans l'ordre.
        /// </summary>
        private List<Manipulation> Manipulations { get; set; }

        /// <summary>
        /// Crée un nouveau conteneur de données pour le chaudron.
        /// </summary>
        private ContenuChandron()
        {
            Manipulations = new List<Manipulation>();
        }

        // Utilisé seulement à des fins de démonstration pour le débogeur.
        /// <inheritdoc/>
        public override string ToString()
        {
            return string.Join(", ", Manipulations);
        }

        /// <summary>
        /// Abstraction du chaudron dans lequel on prépare la potion.
        /// </summary>
        public class Chaudron
        {
            /// <summary>
            /// Liste des manipulations effectuées dans le chaudron.
            /// </summary>
            public List<Manipulation> Manipulations { get; private set; }

            /// <summary>
            /// Crée un nouveau chaudron vide.
            /// </summary>
            public Chaudron()
            {
                Manipulations = new List<Manipulation>();
            }

            /// <summary>
            /// Crée une sauvegarde des manipulations effectuées jusqu'à présent dans le chaudron.
            /// </summary>
            /// <returns>La sauvegarde de l'état du chaudron.</returns>
            public ContenuChandron CreerMemento()
            {
                return new ContenuChandron { Manipulations = Manipulations.GetCopieElements() };
            }

            /// <summary>
            /// Restaure l'état du chaudron dans l'une des sauvegardes précédentes.
            /// </summary>
            /// <param name="contenuChandron">La sauvegarde à utiliser pour la restauration.</param>
            public void SetMemento(ContenuChandron contenuChandron)
            {
                Manipulations = contenuChandron.Manipulations;
            }

            /// <summary>
            /// Ajoute une manipulation au chaudron.
            /// </summary>
            /// <param name="manipulation">La manipulation à ajouter.</param>
            public void AjouterManipulation(Manipulation manipulation)
            {
                Manipulations.Add(manipulation); 
            }

            /// <inheritdoc/>
            public override string ToString()
            {
                return string.Join(", ", Manipulations);
            }
        }
    }
}
