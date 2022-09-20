namespace Memento
{
    /// <summary>
    /// Indique que l'objet peut être cloner. Amélioration de l'interface IClonable disponible 
    /// dans la libraire standard de C#.
    /// </summary>
    /// <typeparam name="T">Le type de l'objet retourné lors d'un clonage.</typeparam>
    internal interface IClonable<T>
    {
        /// <summary>
        /// Crée une copie des champs de l'objet pour éviter un effet de bord lors de
        /// changements sur les types référés.
        /// </summary>
        /// <returns>Une copie de l'objet dans le même type de base ou null s'il est impossible de cloner l'objet.</returns>
        public T? Clone();
    }
}
