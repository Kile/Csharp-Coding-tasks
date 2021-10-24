using System;

/*
Objective 7: Key learning points
Condition controlled iterations
• When it is not known in advance how many times code needs to be repeated, a condition
controlled loop is used.
• Conditions can be set at the end of the iteration so code executes at least once, or at the beginning
of the iteration where code inside the iteration may not execute at all.
• Condition controlled iterations are useful when you want to validate data entry by only continuing
to the next statements once the data input is correct.
• There are many examples of condition controlled iterations, while and do.. while are just two
examples.
• Code should always be indented inside iteration statements.
The conditions return a Boolean value; they are TRUE or FALSE.
*/

namespace LearningTasks
{
    class Objective7
    {
        private static void WhileLoop()
        {
            // Program to add up numbers until 0 is entered
            // Initialise variables
            double total = 0;
            double numberEntered = 1;
            // Enter numbers to add
            while (numberEntered > 0)
            {
                Console.WriteLine("Enter a number: ");
                numberEntered = Convert.ToDouble(Console.ReadLine());
                // Add number to total
                total += numberEntered;
            }
            // Output result
            Console.WriteLine("The sum of the numbers is: " + total);
        }

        private static void DoWhileLoop()
        {
            // Program to add up numbers until 0 is entered
            // Initialise variables
            double total = 0;
            double numberEntered = 1;
            // Enter numbers to add
            do
            {
                Console.WriteLine("Enter a number: ");
                numberEntered = Convert.ToDouble(Console.ReadLine());
                // Add number to total
                total += numberEntered;
            } while (numberEntered > 0); // Condition at the end
            // Output result
            Console.WriteLine("The sum of the numbers is: " + total);
        }
        public static void Run()
        {
            WhileLoop();
            DoWhileLoop();
        }
    }
}