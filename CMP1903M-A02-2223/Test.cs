namespace CMP1903M_A02_2223 {

    class Test {

        public Test() {

                // 
                String mathQuestion = "1 + 2 * 3 - 4 / 5";
                String mathAnswer = (1.0 + 2.0 * 3.0 - 4.0 / 5.0).ToString();
                
                // Split the question into the numbers and operators
                String[] question = mathQuestion.Split(' ');
    
                // Calculate the result
                String result = BODMASCalculator.Calculate(question);

                Console.WriteLine(mathQuestion + " = " + result);
                Console.WriteLine("Program Result: " + mathAnswer);
        }
    }
}