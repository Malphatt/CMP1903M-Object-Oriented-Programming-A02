namespace CMP1903M_A02_2223 {

    class Stats {

        int correctAnswers = 0;
        int incorrectAnswers = 0;
        int totalAnswers = 0;

        public Stats() { readStats(); }

        void readStats() {
            // Read the stats from the file
            String[] stats = System.IO.File.ReadAllLines("stats.txt");

            // Try/Catch to check if the file is empty or contains the correct formatting
            try {

                // Set the stats by getting rid of the text and converting the string to an int
                correctAnswers = int.Parse(stats[0].Replace("Correct Answers: ", ""));
                incorrectAnswers = int.Parse(stats[1].Replace("Incorrect Answers: ", ""));
                totalAnswers = int.Parse(stats[2].Replace("Total Answers: ", ""));

            } catch {

                // If the file is empty, set the stats to 0 and write them to the file
                correctAnswers = 0;
                incorrectAnswers = 0;
                totalAnswers = 0;
                WriteStats();
                
            }
        }

        public void WriteStats() {
            // Write the stats to the file
            System.IO.File.WriteAllLines("stats.txt", new String[] { "Correct Answers: " + correctAnswers.ToString(), "Incorrect Answers: " + incorrectAnswers.ToString(), "Total Answers: " + totalAnswers.ToString() });
        }

        // Increment the correct/incorrect answers and total answers
        public void CorrectAnswer(bool correct) {
            if (correct) {
                correctAnswers++;
            } else {
                incorrectAnswers++;
            }
            totalAnswers++;

            WriteStats();
        }
    }
}