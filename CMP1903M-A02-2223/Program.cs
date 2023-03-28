namespace CMP1903M_A02_2223 {

    class Program {

        // ===========================
        // === Instructions of Use ===
        // ===========================
        //
        // How To Run:
        // 1. Open a new terminal by pressing CTRL + SHIFT + ' (apostrophe) {Or by navigating to Terminal -> New Terminal}
        // 2. Type 'dotnet run' and press ENTER
        // 3. The program will run and you will be able to interact with it

        static void Main(string[] args) {

            // Console.WriteLine("\nWelcome to the Card Pack Program");
            // Console.WriteLine("This program will allow you to shuffle and deal cards from a pack of 52 cards");
            // Console.WriteLine("Press ENTER to go back at any point or 'Q' to quit the program");
            // Console.WriteLine("Additionally, you can type 'P' to print the pack at any point\n");

            new Menu();
            // Console.WriteLine(new BODMASCalculator().Calculate(new String[9] { "1", "+", "2", "*", "3", "-", "4", "/", "5" }));
        }
    }
}
