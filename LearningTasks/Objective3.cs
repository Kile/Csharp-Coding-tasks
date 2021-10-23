using System;

/*
Objective 3: Key learning points
String manipulation functions
• Strings can be manipulated using the built in Substring function to extract characters from the
left, right or middle of a string.
• You can find if one string exists inside another string using IndexOf.
• A built in function takes data to use in parenthesis (brackets), called a parameter and returns a
result.
*/

namespace LearningTasks
{
    class Objective3
    {
        public static void Run()
        {
            // Substring is used to slice up strings
            // The position of the firsz character in a string is always 0
            // Known as 'zero-based strings'
            string sentence, characters;
            sentence = "I saw a wolf in the forest. A lonely wolf.";
            // Note below the 0 could be omitted; 0 is the default
            characters = sentence.Substring(sentence.Length-12);
            // alternative: characters = sentence.Substring(sentence.Length-12, 12)
            Console.WriteLine("Last 12 characters: " + characters);
        }
    }
}