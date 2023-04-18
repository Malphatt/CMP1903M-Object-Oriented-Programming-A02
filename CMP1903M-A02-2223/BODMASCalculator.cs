namespace CMP1903M_A02_2223 {

    class BODMASCalculator {

        // Calculate() will take an array of string values such as "1", "+", "2", "*", "3", "-", "4", "/", "5"
        // and return the result of the calculation
        // If the input is invalid, it will return -1
        // calls other methods to calculate the result
        public String Calculate(String[] input) {

            if (input.Length % 2 == 0) { // Checks if the input is valid (must be odd length)
                return "Invalid Input";
            }

            String result = "";
            
            // Loop through the input array until there is only 1 value left (the result)
            while (input.Length > 1) {

                Console.WriteLine("Pass");
                
                // Loop through the operators from the last one and find the highest priority operator location (BODMAS)
                int highestPriorityOperatorLocation = 0;
                String highestPriorityOperator = "";
                for (int i = input.Length - 2; i >= 0; i -= 2) {

                    // Check if the operator is the highest priority
                    if (input[i] == "/" || input[i] == "*") {
                        highestPriorityOperatorLocation = i;
                        highestPriorityOperator = input[i];
                    } else
                    if ((input[i] == "+" || input[i] == "-") && !(highestPriorityOperator == "/" || highestPriorityOperator == "*")) {
                        highestPriorityOperatorLocation = i;
                        highestPriorityOperator = input[i];
                    }
                }
                

                // Calculate the result of the highest priority operator
                if (input[highestPriorityOperatorLocation] == "/") {
                    result = Division(input[highestPriorityOperatorLocation - 1], input[highestPriorityOperatorLocation + 1]);
                } else
                if (input[highestPriorityOperatorLocation] == "*") {
                    result = Multiplication(input[highestPriorityOperatorLocation - 1], input[highestPriorityOperatorLocation + 1]);
                } else
                if (input[highestPriorityOperatorLocation] == "+") {
                    result = Addition(input[highestPriorityOperatorLocation - 1], input[highestPriorityOperatorLocation + 1]);
                } else
                if (input[highestPriorityOperatorLocation] == "-") {
                    result = Subtraction(input[highestPriorityOperatorLocation - 1], input[highestPriorityOperatorLocation + 1]);
                }

                // Replace the 3 values in the input array with the result
                List<String> inputList = input.ToList();
                inputList.RemoveRange(highestPriorityOperatorLocation - 1, 3);
                inputList.Insert(highestPriorityOperatorLocation - 1, result);
                input = inputList.ToArray();

            }
            return result;
        }

        // Methods to calculate the result of the operators
        // These methods are called by Calculate()
        // They take 2 values and return the result of the calculation
        // They are all private as they are only used by Calculate()

        protected String Division(String x, String y) {
            return (float.Parse(x) / float.Parse(y)).ToString();
        }

        protected String Multiplication(String x, String y) {
            return (float.Parse(x) * float.Parse(y)).ToString();
        }

        protected String Addition(String x, String y) {
            return (float.Parse(x) + float.Parse(y)).ToString();
        }

        protected String Subtraction(String x, String y) {
            return (float.Parse(x) - float.Parse(y)).ToString();
        }
    }
}