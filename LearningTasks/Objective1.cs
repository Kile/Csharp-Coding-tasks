using System;

/*
Objective 1: Key learning points
Understand how to output text strings
• Text is known as a string in programming and must be enclosed in double quotes.
• Strings can be joined together using a plus symbol. This is known as concatenation.
• When a program is run it is called executing the program.
• A set of instructions that execute one after another is known as a sequence.
• Comments can be inserted into the code using a double // symbol. These are helpful to make
notes within the program so that the code can be understood again at a later date or by another
programmer.
*/

namespace LearningTasks 
{

    class Objective1 
    {
        public static void Run()
        {
            // Start on message 
            Console.WriteLine("Objective 1 Tasks:");
            Console.WriteLine("------------------");
            // Console.WriteLine("Hello" + " this is my first program.");
            // Blank line
            // Console.WriteLine();
            // End of message
            Console.WriteLine("Computers only do exactly as they are told...");
            Console.WriteLine("...so you need the code to be correct!");
            Console.WriteLine();
            Console.WriteLine("If you make any mistake with the commands, it won’t work");
            // Wait for the user to exit (if necessary)
            Console.ReadLine();
        }
    }
}