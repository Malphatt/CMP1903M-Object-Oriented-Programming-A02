namespace CMP1903M_A02_2223 {

    abstract class CardOperator {
        
        // Replacing the overridden ToString method
        // to return the suit of the card in the form of a mathematical operator
        public String GetOperator(int Suit) {

            String[] cardSuits = new String[4] { "+", "-", "*", "/" };

            return cardSuits[Suit - 1];
        }
    }
}