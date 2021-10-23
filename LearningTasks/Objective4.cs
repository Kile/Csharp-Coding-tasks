using System;

/*
Objective 4: Key learning points
How to use selection statements
• Checking the value of a variable and executing instructions depending on the outcome of the check
is known as a selection.
• The instructions that are executed as a result of a selection is known as a program branch.
• The logical checking of a variable against another value is known as a condition.
• Switch/case commands can be used instead of multiple if statements.
• Code for each program branch should be indented.
• It is good practice to comment a selection to explain its purpose.
• One ‘If’ can be placed inside another ‘If’, this is known as nesting.
*/

namespace LearningTasks
{
    class Objective4
    {
        private static void Switch()
        {
            // Using switch selection
            // More efficient with 1 variable and several possibilities
            string choice;
            // Ask user for the number
            Console.WriteLine("1. Add numbers\n" +
                "2. Subtract numbers\n" +
                "3. Quit\n" +
                "Enter your choice: ");
            choice = Console.ReadLine();
            // Multiple branches depending on selection
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Add numbers chosen");
                    break;
                case "2":
                    Console.WriteLine("Substract numbers chosen");
                    break;
                case "3":
                    Console.WriteLine("Quit chosen");
                    break;
                default:
                    Console.WriteLine("Invalid option chosen");
                    break;
            }
        }

        public static void IfStatement()
        {
            string str1, str2;
            // int chr1, chr2
            Console.WriteLine("Enter first string: ");
            str1 = Console.ReadLine();
            Console.WriteLine("Enter second string: ");
            str2 = Console.ReadLine();
            // use String.Compare
            /* String.Compare compares two strings, in this case str1 and str2, and returns:
            • 1 if the first string is highest
            • -1 if the second string is highest
            • 0 if they match */
            if (String.Compare(str1, str2, StringComparison.Ordinal) == 0)
            {
                Console.WriteLine("String '{0}' abd '{1}' match.", str1, str2);
            } else if (String.Compare(str1, str2, StringComparison.Ordinal) < 0)
            {
                Console.WriteLine("String '{0}' is less than string '{1}'.", str1, str2);
            } else
            {
                Console.WriteLine("String '{0}' is greater than string '{1}'.", str1, str2);
            }
        }

        public static void Run()
        {
            Switch();
            IfStatement();
        }
    }
}