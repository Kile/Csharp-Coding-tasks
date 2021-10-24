using System;

/*
Objective 8: Key learning points
Understand subroutines, procedures and functions
• Subroutines are sections of code to break a longer programs into smaller pieces. Thereby making
them easier to read and more manageable for teams of programmers to work together on one
program.
• Subroutines are also known as procedures or methods.
• Functions carry out small tasks on data by taking one or more parameters and returning a result.
To run a subroutine, you call it using its name (known as its identifier).
• Subroutines/procedures may also take parameters, but do not return a result.
• It is good practice to comment each subroutine or function to explain its purpose.
• Variables declared outside of all subroutines are known as global variables. They are available to
all subroutines and functions.
• Global variables are not memory efficient since they hold memory for the entire time a program is
running. They should therefore be kept to a minimum.
• Variables declared inside a subroutine or function are known as local variables. They lose their
value when the routine ends, releasing memory.
• Passing variables between subroutines is known as parameter passing.
*/

namespace LearningTasks
{
    class ProgramDummy
    {
        // Gloabal variables accessed by all subroutines
        static int MaxNoOfStars, NoOfStars, NoOfSpaces;
        public static void _Main(string[] args)
        {
            InitialiseNoOfSpaceAndStars(); // Main program starts here
            do
            {
                OutputLeadingSpaces();
                OutputLineOfStars();
                AdjustNoOfSpacesAndStars();
            } while (NoOfStars <= MaxNoOfStars);
        }

        // Set the size of the pyramid of stars
        static void InitialiseNoOfSpaceAndStars()
        {
            Console.Write("How many stars are at the base (1-40)? ");
            MaxNoOfStars = Convert.ToInt32(Console.ReadLine());
            NoOfSpaces = MaxNoOfStars / 2; // Calculate spaces needed from tip
            NoOfStars = 1;                 // Set tip of pyramid to one star
        }

        //Outputs spaces before stars
        static void OutputLeadingSpaces()
        {
            for (int count = 1; count <= NoOfSpaces; count++) Console.Write(" ");
        }

        // Output stars
        static void OutputLineOfStars()
        {
            for (int count = 1; count <= NoOfStars; count++) Console.Write("*");
            Console.WriteLine(); // Move to next line
        }

        // Adjust number of stars & spaces after output
        static void AdjustNoOfSpacesAndStars()
        {
            NoOfSpaces -= 1;
            NoOfStars += 2;
        }
    }

    class ProgramDummy2
    {
        public static void _Main(string[] args)
        {
            // task 2a: Program to output a set of random numbers using parameters
            int number, max;
            Console.Write("How many numbers do you want to output? ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is the maximum number? ");
            max = Convert.ToInt32(Console.ReadLine());
            OutputRandoms(number, max); // data sent into the procedure
        }

        // task 2b: Output random numbers
        // note parameters in brackets after the method name
        static void OutputRandoms(int n, int m)
        {
            int counter, randomNum;
            Random rnd = new Random();
            m +=1; // because the max value in Next() in EXCLUSIVE
            for (counter = 1; counter <= n; counter++)
            {
                randomNum = rnd.Next(m);
                Console.WriteLine("Number {0} is {1}", counter, randomNum);
            }
        }
    }

    class ProgramDummy3
    {
        public static void _Main(string[] args)
        {
            // task 3a: How functions can be used
            int num1, num2;
            Console.WriteLine("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The floor number is: " + Floor(num1, num2));
        }

        static int Floor(int a, int b)
        {
            // task 3b: Returns a positive number from substraction
            int f;
            f = a - b;
            if (f > 0) {return f;} else {return 0;}
        }
    }
    class Objective8
    {
        public static void Run()
        {
            ProgramDummy._Main(new string[0]);
            ProgramDummy2._Main(new string[0]);
            ProgramDummy3._Main(new string[0]);
        }
    }
}