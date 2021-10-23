using System;

/*
Objective 5: Key learning points
How to use arithmetic operations and random numbers
• / performs division. If the operand data types are integers, it does integer division, giving an integer
answer. If the operands are decimal data types (eg double), then it performs regular division.
• Modulus is the remainder of a division. E.g. 8 divided by 5 is one with 3 left over (remainder)
• Commands can be put inside commands. E.g. Convert.ToInt32(Console.ReadLine())is two
commands, one inside the other. This example is converting an input into an integer.
• A variable is stored with a specific data type that determines how much memory it uses and how it
is handled in the program. Typical data types include: integer, real/float (double/decimal),
character, string, date and boolean.
• Some data types have identifying characters. E.g. a string is enclosed in quotes.
• The integer 7, is therefore not the same as the character “7”. They have different binary values.
• It is possible to change a variable’s data type using conversion functions (Convert).
*/

namespace LearningTasks
{
    class Objective5
    {
        private static void Division()
        {
            // Declare variables with double data type for decimal values
            double number1, number2;
            double divisionResult;

            // Convert user input into doubles
            Console.WriteLine("Enter first number: ");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            number2 = Convert.ToDouble(Console.ReadLine());

            divisionResult = number1 / number2;
            Console.WriteLine();
            Console.WriteLine("{0} divided by {1} is {2}", number1, number2, divisionResult);
        }

        private static void Dice()
        {
            // Declare variables
            Random rnd = new Random(); // Generate a new random number object
            int randomNumber;
            string dice;

            Console.WriteLine("Please chose what dice to roll\n" +
                "1. 4 sided dice\n" +
                "2. 6 sided dice\n" +
                "3. 12 sided dice");

            dice = Console.ReadLine();
            // Roll the dice
            switch(dice)
            {
                case "1":
                    randomNumber = rnd.Next(1, 5);
                    break;
                case "2":
                    randomNumber = rnd.Next(1, 7);
                    break;
                case "3":
                    randomNumber = rnd.Next(1, 13);
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    return;
            }
            Console.WriteLine("You rolled a " + randomNumber);
        }
        public static void Run()
        {
            Division();
            Dice();
        }
    }
}