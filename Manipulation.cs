namespace Memento
{
    /// <summary>
    /// Manipulation dans le chaudron des potions.
    /// </summary>
    public class Manipulation : IClonable<Manipulation>
    {
        /// <summary>
        /// Nom de la manipulation.
        /// </summary>
        public string Nom { get; private set; }

        /// <summary>
        /// Constructeur de la manipulation.
        /// </summary>
        /// <param name="nom">Le nom de la manipulation effectuée.</param>
        public Manipulation(string nom)
        {
            Nom = nom;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return Nom;
        }

        /// <inheritdoc/>
        public Manipulation? Clone()
        {
            string? cloneNom = Nom.Clone() as string;

            if(cloneNom is not null)
            {
                return new Manipulation(cloneNom);
            }
            else
            {
                return null;
            }
        }
    }
}
