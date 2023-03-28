namespace CMP1903M_A02_2223 {

    class Card {

        public Card(int suit, int value) {
            Suit = suit;
            Value = value;
        }

        // Encapsulation has been used to ensure that the value and suit of a card cannot be changed to an invalid value
        // Value and Suit are private and can only be accessed through the public get and set methods
        int _value;
        public int Value {
            get { return _value; }
            set {
                if (value > 0 && value < 14) {
                    _value = value;
                } else {
                    throw new Exception("Invalid Card Value: " + value);
                }
            }
        }
        int _suit;
        public int Suit {
            get { return _suit; }
            set {
                if (value > 0 && value < 5) {
                    _suit = value;
                } else {
                    throw new Exception("Invalid Card Suit: " + value);
                }
            }
        }

        // Replacing the overridden ToString method
        // to return the suit of the card in the form of a mathematical operator
        public String GetOperator() {

            String[] cardSuits = new String[4] { "+", "-", "*", "/" };

            return cardSuits[Suit - 1];
        }
    }
}
