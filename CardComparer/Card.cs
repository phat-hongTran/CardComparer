namespace CardComparer
{
    class Card
    {
        public Values Value { get; private set; }
        public Suits Suit { get; private set; }

        public readonly string Name;

        public Card( Values value, Suits suit)
        {
            this.Value = value;
            this.Suit = suit;

            Name = $"{Value} of {Suit}";
        }
    }
}
