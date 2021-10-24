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
    class Objective6
    {

        private static void ForEachLoop()
        {
            Console.WriteLine("Please enter a word: ");
            string word = Console.ReadLine();
            foreach (char letter in word)
            {
                Console.WriteLine("Letter {0} has an ASCII/Unicode value of {1}", letter, (int)letter);
            }
        }

        private static void ForLoop()
        {
            string word = "Hello";
            for (int counter = 0; counter < word.Length; counter++)
            {
                Console.WriteLine("Letter {0} is a '{1}'", counter, word.Substring(counter, 1));
            }
        }
        public static void Run()
        {
            ForLoop();
            ForEachLoop();
        }
    }
}