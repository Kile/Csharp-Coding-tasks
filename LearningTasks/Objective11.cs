using System;

/*
Objective 11: Key learning points
How to handle exceptions for validation
• There are 3 types of errors in programming:
    o Syntax errors when you mistype a keyword, the program doesn't recognise it as a valid
    command and will not run.
    o Logic errors where the program runs but you get the wrong result, perhaps not always
    consistently! Logic errors are called bugs.
    o Run-time errors that occur in exceptional circumstances such as division by zero and
    incorrect data type input. These should be trapped with exception handling commands.
• Fixing errors in code is known as debugging.
• Preventing invalid data input is known as validation. There are a number of different types of
validation including:
• Presence checks: did the user actually enter any data?
    o Range checks: does the input fall within a valid range of numbers?
    o Format check: does the input match a recognised format, e.g. LLNN NLL for postcode
    o Length check: is the input the required length of characters, e.g. minimum 8 character
password.
• Most validation checks can be performed with selection and iteration statements, but sometimes
an error could occur if one data type is converted to another, e.g. a string to an integer if the
character is not a number.
• The development environment may contain a variety of tools to assist you in debugging a program:
    o Highlighting incorrect key words.
    o Compiler output errors that tell you why your program won't run.
    o Break points to stop the program at a particular point to check the value of variables.
    o Stepping through the program line by line to see what command is executing.
    o Tracing the value of variables as they step through the program.
    o An immediate window where you can try commands and see the output.
*/

namespace LearningTasks
{
    class Objective11
    {
        public static void Run()
        {
            // Run time errors
            decimal num1, num2, answer;
            num1 = 0;
            num2 = 0;
            // Get numbers
            try
            {
                Console.WriteLine("Enter a number:");
                num1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter a number:");
                num2 = Convert.ToDecimal(Console.ReadLine());
            } catch {
                Console.WriteLine("Invalid entry");
                return; // This prevents the rest of the code of being executed
            }

            // Output
            try 
            {
                answer = num1 / num2;
                Console.WriteLine("{0} divided by {1} = {2}", num1, num2, answer);
            } catch {
                Console.WriteLine("Unable to divide by 0 error");
            }
        }
    }
}