using System.Collections.Generic;

namespace Memento
{
    /// <summary>
    /// Ajoute des opérations à la liste standard de C#.
    /// </summary>
    internal static class ListExtension
    {
        /// <summary>
        /// Retourne une copie de la liste dont tous les éléments sont clonés.
        /// 
        /// NE GARANTI PAS QUE TOUS LES ÉLÉMENTS SONT CLONÉS.
        /// </summary>
        /// <typeparam name="T">Le type d'éléments contenus dans la liste.</typeparam>
        /// <param name="liste">La liste de laquelle cloner des éléments.</param>
        /// <returns>Une copie de la liste dont tous les éléments sont clonés. Si le clonage d'un élément est null,
        /// alors l'élément est ignoré.</returns>
        public static List<T> GetCopieElements<T>(this List<T> liste) where T : IClonable<T> 
        {
            List<T> copieListe = new List<T>();
            foreach (T item in liste)
            {
                T? clone = item.Clone();
                if(clone is not null)
                {
                    copieListe.Add(clone);
                }
            }

            return copieListe;
        }
    }
}
