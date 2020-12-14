namespace Properties
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// The class models a card.
    /// </summary>
    public class Card : IEquatable<Card>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param name="name">the name of the card.</param>
        /// <param name="seed">the seed of the card.</param>
        /// <param name="ordinal">the ordinal number of the card.</param>
        public Card(string name, string seed, int ordinal)
        {
            this.Name = name;
            this.Ordinal = ordinal;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param name="tuple">the informations about the card as a tuple.</param>
        internal Card(Tuple<string, string, int> tuple)
            : this(tuple.Item1, tuple.Item2, tuple.Item3)
        {
        }

        // TODO improve
        public string Seed
        {
            get;
        }

        // TODO improve
        public string Name
        {
            get;

        }

        // TODO improve
        public int Ordinal
        {
            get;

        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Card);
        }

        public bool Equals([AllowNull] Card other)
        {
            return other != null &&
                   Seed == other.Seed &&
                   Name == other.Name &&
                   Ordinal == other.Ordinal;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Seed, Name, Ordinal);
        }

        /// <inheritdoc cref="object.ToString"/>
        public override string ToString() =>
            // TODO understand string interpolation
            $"{this.GetType().Name}(Name={Name}, Seed={Seed}, Ordinal={Ordinal})";

        // TODO generate Equals(object obj)

        // TODO generate GetHashCode()
    }
}
