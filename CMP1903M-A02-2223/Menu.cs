namespace CMP1903M_A02_2223 {

    class Menu {

        Stats statistics = new Stats(); // Create a new stats object

        bool repeat = true; // Boolean to control the main menu loop

        public Menu() {
            new Pack(); // Create a new pack of cards

            Console.WriteLine("\nWelcome to the MathTutor Program"); // Welcome message

            while (repeat) {

                // This is done to ensure the pack will not run out of cards
                Pack.ResetPack(); // Reset the pack of cards
                Pack.shuffleCardPack(1); // Shuffle the pack of cards using the Fisher Yates Shuffle

                // Show the main menu
                mainMenu();
            }
        }

        void mainMenu() {

            Console.Write("\nPlease select an option from the menu below:\n  1. Instructions\n  2. Deal 3 Cards\n  3. Deal 5 Cards\n  4. Quit\nEnter your selection: ");

            string? input = Console.ReadLine();

            if (input == null || input == "") {
                Console.WriteLine("Please enter a valid input");
                return;
            } else
            if (input == "1") {
                showInstructions();
                return;
            } else
            if (input == "2") {
                dealCards(3);
                return;
            } else
            if (input == "3") {
                dealCards(5);
                return;
            } else
            if (input == "4") {
                quitProgram();
                return;
            } else {
                Console.WriteLine("Please enter a valid input");
                return;
            }

        }

        void showInstructions() {
                
                Console.Write("\n  1. Upon dealing a number of cards you will be presented with a Year 1 / Year 2 math problem."
                    + "\n  2. You will be asked to solve the problem and enter your answer."
                    + "\n  3. If your answer is correct or incorrect you will be told so."
                    + "\n  4. You will be able to deal the same number of cards after entering the answer."
                    + "\n  5. You will also be able to return to the main menu after dealing the cards."
                    + "\n  6. Remember to use the BODMAS rule when solving the problem, divisions are formatted to 2 decimal places where necessary (make sure to round up or down)."
                    + "\n  7. You can quit the program by selecting the 'Quit' option from the main menu."
                    + "\n\nPress ENTER to return to the main menu...");

                Console.ReadLine();
        }

        void dealCards(int amount) {

            List<Card> cards = Pack.dealCard(amount);
            String[] cardMathArray = new String[amount];

            for (int i = 0; i < amount; i++) {
                if (i % 2 == 0) {
                    cardMathArray[i] = cards[i].Value.ToString();
                } else {
                    cardMathArray[i] = cards[i].GetOperator();
                }
            }

            String answer = new BODMASCalculator().Calculate(cardMathArray);

            Console.Write("\nWhat is the answer to the following equation: ");
            for (int i = 0; i < amount; i++) {
                Console.Write(cardMathArray[i] + " ");
            }
            Console.Write("= ");

            String? input = Console.ReadLine();

            if (input == answer) {
                Console.WriteLine("Correct!");
                statistics.CorrectAnswer(true);
            } else {
                Console.WriteLine("Incorrect!");
                Console.WriteLine("The correct answer is: " + answer);
                statistics.CorrectAnswer(false);
            }

            bool againSuccess = false;
            while(!againSuccess) {

                Console.Write("\nWould you like to:\n  1. Deal Again?\n  2. Return to Main Menu?\nEnter your selection: ");
                String? againInput = Console.ReadLine();

                if (againInput == null || againInput == "") {
                    Console.WriteLine("Please enter a valid input");
                } else
                if (againInput == "1") {

                    // Reset the pack of cards and shuffle it
                    Pack.ResetPack();
                    Pack.shuffleCardPack(1);

                    dealCards(amount);
                    againSuccess = true;
                    
                } else
                if (againInput == "2") {
                    againSuccess = true;
                } else {
                    Console.WriteLine("Please enter a valid input");
                }
            }


        }

        void quitProgram() {
            
            Console.WriteLine("\nGoodbye!\n");
            repeat = false;

        }
    }
}