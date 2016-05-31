namespace SharedModels
{
    public enum Suit
    {
         Spades, Hearts, Clubs, Diamonds
    }

    /// <summary>
    /// Card face values
    /// </summary>
    public enum FaceValue
    {
        Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace
    }
    public class Card
    {
        public Suit Suit { get; }
        public FaceValue FaceValue { get; }
        public bool IsCardUp { get; set; }

        public int Point { get; set; }
        public bool Major { get; set; }

        public string CardFaceFileName { get; set; }
        /// <summary>
        /// Constructor for a new card.  Assign the card a suit, face value, and if the card is facing up or down
        /// </summary>
        /// <param name="suit"></param>
        /// <param name="faceValue"></param>
        /// <param name="isCardUp"></param>
        public Card(Suit suit, FaceValue faceValue, bool isCardUp)
        {
            this.Suit = suit;
            this.FaceValue = faceValue;
            this.IsCardUp = isCardUp;
            Point = GetPoint();
            Major = GetMajorOrMinor();
            
        }

        private int GetPoint()
        {

            switch (FaceValue)
            {
                case FaceValue.Jack:
                    return 1;
                case FaceValue.Queen:
                    return 2;
                case FaceValue.King:
                    return 3;
                case FaceValue.Ace:
                    return 4;
                default:
                    return 0;
            }
        }
        private bool GetMajorOrMinor()
        {
            return Suit > Suit.Diamonds;
        }

        public string GetImageFileName(Card card)
        {
            string fileName = "";

            switch (card.Suit)
            {
                case Suit.Clubs:
                    fileName = "C";
                    break;
                case Suit.Diamonds:
                    fileName = "D";
                    break;
                case Suit.Spades:
                    fileName = "S";
                    break;
                case Suit.Hearts:
                    fileName = "H";
                    break;

            }


            switch (card.FaceValue)
            {
                case FaceValue.Two:
                    fileName += "2";
                    break;
                case FaceValue.Three:
                    fileName += "3";
                    break;
                case FaceValue.Four:
                    fileName += "4";
                    break;
                case FaceValue.Five:
                    fileName += "5";
                    break;
                case FaceValue.Six:
                    fileName += "6";
                    break;
                case FaceValue.Seven:
                    fileName += "7";
                    break;
                case FaceValue.Eight:
                    fileName += "8";
                    break;
                case FaceValue.Nine:
                    fileName += "9";
                    break;
                case FaceValue.Ten:
                    fileName += "10";
                    break;
                case FaceValue.Jack:
                    fileName += "J";
                    break;
                case FaceValue.Queen:
                    fileName += "Q";
                    break;
                case FaceValue.King:
                    fileName += "K";
                    break;
                case FaceValue.Ace:
                    fileName += "A";
                    break;
            }
            return fileName + ".png";
        }


    }
}
