using System;
using System.Collections.Generic;


namespace Memento
{
    /// <summary>
    /// Responsable de gérer la manipulation du chaudron et la gestion de son contenu.
    /// </summary>
    public class Gestionnaire
    {
        /// <summary>
        /// Liste des contenus du chaudron (étapes).
        /// </summary>
        private Stack<ContenuChandron> contenus;

        /// <summary>
        /// Le chaudron sur lequel on fait des manipulations.
        /// </summary>
        public ContenuChandron.Chaudron Chaudron { get; private set; }

        /// <summary>
        /// Crée un nouveau gestionnaire avec un chaudron vide.
        /// </summary>
        public Gestionnaire()
        {
            contenus = new Stack<ContenuChandron>();
            Chaudron = new ContenuChandron.Chaudron();
        }

        /// <summary>
        /// Ajoute une nouvelle manipulation à la préparation de potion.
        /// </summary>
        /// <param name="manipulation">La manipulation à ajouter.</param>
        public void AjouterManipulation(Manipulation manipulation)
        {
            contenus.Push(Chaudron.CreerMemento());         // Enregistre l'état actuel avant de faire l'ajout
            Chaudron.AjouterManipulation(manipulation);
        }

        /// <summary>
        /// Annule la dernière manipulation et restaure le chaudron dans son état précédent.
        /// </summary>
        /// <exception cref="InvalidOperationException">S'il n'y a pas d'opération à annuler.</exception>
        public void AnnulerDerniereManipulation()
        {
            if(contenus.Count > 0)
            {
                Chaudron.SetMemento(contenus.Pop());
            }
            else
            {
                throw new InvalidOperationException("Il n'y a pas de manipulation à annuler.");
            }
        }
    }
}
