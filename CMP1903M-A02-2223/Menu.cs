namespace CMP1903M_A02_2223 {

    class Menu {


        public Menu() {
            new Pack(); // Create a new pack of cards

            while (true) {
                mainMenu();
            }
        }

        void mainMenu() {
            Console.WriteLine("\nWelcome to the MathTutor Program");

            // Console.WriteLine("This program will allow you to shuffle and deal cards from a pack of 52 cards");
            // Console.WriteLine("Press ENTER to go back at any point or 'Q' to quit the program");
            // Console.WriteLine("Additionally, you can type 'P' to print the pack at any point\n");

            Console.WriteLine("Please select an option from the menu below:");
            Console.WriteLine("1. Instructions");
            Console.WriteLine("2. Deal 3 Cards");
            Console.WriteLine("3. Quit");
            Console.Write("Enter your selection: ");

            string? input = Console.ReadLine();

        }

        void quitProgram() {
            
            Console.WriteLine("Goodbye!");
            Environment.Exit(0);

        }
    }
}