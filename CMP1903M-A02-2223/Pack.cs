namespace CMP1903M_A02_2223 {

    class Pack {

        static List<Card> pack = new List<Card>(52);

        public Pack() {

        // Creates a new pack of cards with 52 cards in it (4 suits, 13 values)
        // Unnecessary to have error checking as the pack is set within the code and not user defined
            for (int i = 0; i < 52; i++) {
                pack.Add(new Card((i / 13) + 1, (i % 13) + 1));
            }
        }

    // Shuffles the pack based on the type of shuffle specified
        public static bool shuffleCardPack(int typeOfShuffle) {
            
            switch (typeOfShuffle) {
            // Fisher Yates Shuffle
                case 1:
                    pack = Shuffle.fisherYatesShuffle(pack);
                    return true;
            // Riffle Shuffle
                case 2:
                    pack = Shuffle.riffleShuffle(pack);
                    return true;
            // No Shuffle
                case 3:
                    return true;
            // Invalid Shuffle
                default:
                    Console.WriteLine("Invalid Shuffle Type: " + typeOfShuffle);
                    return false;
            }
        }

        public static Card deal() { // Deals a single card from the pack

        // Gets the first card in the pack
            Card returnCard = pack[0];
        // Removes the card from the pack
            pack.RemoveAt(0);
        // Returns a single card from the pack
            return returnCard;
        }
        
        public static List<Card> dealCard(int amount) { // Deals the specified amount of cards from the pack

        // Creates a new list of cards to return
            List<Card> returnCards = new List<Card>(amount);

        // Adds the specified amount of cards to the return list
            for (int i = 0; i < amount; i++) {
                returnCards.Add(deal());    
            }

            return returnCards;
        }

        public static int GetPackSize() { // Returns the size of the pack
            return pack.Count;
        }

        public static void PrintPack() { // Prints the pack to the console

            Console.WriteLine("\nPack:");

            foreach (Card card in pack) {
                Console.WriteLine("  " + card.ToString());
            }
        }

        public static void ResetPack() { // Resets the pack to the original 52 cards
            pack.Clear();
            for (int i = 0; i < 52; i++) {
                pack.Add(new Card((i / 13) + 1, (i % 13) + 1));
            }
            Console.WriteLine("The pack has been reset\n");
        }
    }
}
