namespace CMP1903M_A02_2223 {

    class Shuffle {

    // =================================
    // == Fisher-Yates Shuffle Method ==
    // =================================
    // This method is based on the Fisher-Yates shuffle algorithm
    //
    // Description of the algorithm:
    // It is a modern algorithm that is considered to be the best way to shuffle a deck of cards
    // The algorithm effectively puts all the elements into a hat;
    // It continually determines the next element by randomly drawing an element from the hat until no elements remain.
    //
    // Steps to reproduce the algorithm:
    // 1. Write down the numbers from 1 through N.
    // 2. Pick a random number k between one and the number of unstruck numbers remaining (inclusive).
    // 3. Counting from the low end, strike out the kth number not yet struck out, and write it down at the end of a separate list.
    // 4. Repeat from step 2 until all the numbers have been struck out.
    // 5. The sequence of numbers written down in step 3 is now a random permutation of the original numbers.
    //
    // Source: https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle

        public static List<Card> fisherYatesShuffle(List<Card> pack) {

        // Create a new random object
            Random random = new Random();
        // Create a new list to hold the shuffled pack
            List<Card> shuffledPack = new List<Card>(pack.Count());

        // Loop through the pack and add a random card to the shuffled pack
            for (int i = pack.Count(); i > 0; i--) {
                int randomIndex = random.Next(i);           // Get a random index from the pack that hasn't been added to the shuffled pack yet
                shuffledPack.Insert(0, pack[randomIndex]);  // Inserts the card at the random index to the start of the shuffled pack
                pack.RemoveAt(randomIndex);                 // Remove the card at the random index from the pack so it can't be added again
            }

            return shuffledPack;
        }


    // ===========================
    // == Riffle Shuffle Method ==
    // ===========================
    // This method is based on the riffle shuffle algorithm
    //
    // Description of the algorithm:
    // The riffle shuffle is a method of shuffling a deck of cards.
    // It is a simple method that is easy to perform and can be done in the hands.
    // The deck is divided into two halves, and the halves are shuffled together.
    // The halves are then divided into two smaller halves, and the halves are shuffled together again.
    // This process is repeated until the deck is shuffled. (For this algorithm, this is not carried out)
    //
    // Steps to reproduce the algorithm:
    // 1. Split the deck into two halves.
    // 2. Shuffle the halves together by releasing the halves at the same time and allowing them to interlace.
    // 3. Repeat steps 1 and 2 until the deck is shuffled. (For this algorithm, this is not carried out)
    //
    // Source: https://en.wikipedia.org/wiki/Riffle_shuffle
    // Source: https://youtu.be/f6ZD1lDbW3M?t=22
    
        public static List<Card> riffleShuffle(List<Card> pack) {

            if (pack.Count() % 2 == 0) { // Check if the pack is an even number of cards

                int deckCount = pack.Count(); // Should be 52 for a full deck
                int halfDeckCount = deckCount / 2; // Should be 26 for a half deck

            // Split the deck into two halves
                List<Card> topHalf = pack.GetRange(0, halfDeckCount);
                List<Card> bottomHalf = pack.GetRange(halfDeckCount, halfDeckCount);

            // Shuffle the halves together
            // Decided to start with the bottom half so that the top card isn't the same after the shuffle (as the code shuffles in reverse order to how it is presented in real life)
                List<Card> shuffledPack = new List<Card>(deckCount);
                for (int i = 0; i < halfDeckCount; i++) {
                    shuffledPack.Add(bottomHalf[i]);
                    shuffledPack.Add(topHalf[i]);
                }

                return shuffledPack;

            } else
            if (pack.Count() % 2 != 0) { // Check if the pack is an odd number of cards
                
            // This also works for a pack with 1 card as the pack will be returned as is during the recursive call
                List<Card> packMinusLastCard = pack.GetRange(0, pack.Count() - 1); // Remove the last card from the pack
                List<Card> shuffledPackMinusLastCard = riffleShuffle(packMinusLastCard); // Shuffle the pack minus the last card
                shuffledPackMinusLastCard.Add(pack[pack.Count() - 1]); // Add the last card to the shuffled pack

                return shuffledPackMinusLastCard;

            } else { // If the pack is empty, return the pack
                return pack;
            }
        }
    }
}