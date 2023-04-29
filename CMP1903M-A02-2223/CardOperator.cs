namespace CMP1903M_A02_2223 {

    abstract class CardOperator {
        
        // Replacing the overridden ToString method
        // to return the suit of the card in the form of a mathematical operator
        public String GetOperator(int Operator) {

            String[] cardOperators = new String[4] { "+", "-", "*", "/" };

            return cardOperators[Operator - 1];
        }
    }
}