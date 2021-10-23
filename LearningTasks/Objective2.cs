using System;

/*
Objective 2: Key learning points
How to input strings and numbers into variables
• Data is input by a user into a variable.
• Memory is reserved for variables when you declare the variable.
• Variables have a data type: string, integer or decimal as examples, indicating how much memory
they will use and the type of data they will store.
• Variables must be declared before they can be used.
• Variable declaration takes the form of: data_type identifier;
*/

namespace LearningTasks
{
    class Objective2
    {
        public static void Run()
        {
            // Declare variables
            // The type of data comes first, then the variable name or identifier
            string nameEntered;
            int age;
            // Inputting strings
            Console.WriteLine("Hello");
            Console.WriteLine("What is your name?");
            nameEntered = Console.ReadLine();
            Console.WriteLine("What is your age?");
            age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Thank you " + nameEntered + ". You have registered an age of {0}.", age);
            // note the variable concatenated on the end
        }
    }
}