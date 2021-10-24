using System;
using System.Reflection;

namespace LearningTasks
{
    class Program
    {

        private static void RunEmAll()
        {
            for (int i = 1; i < 12; i++)
            {
                Console.WriteLine("----------------");
                Console.WriteLine("Now running objective {0}", i); // Inform the user what is currently run
                Console.WriteLine("----------------\n");
                Type t = Type.GetType($"LearningTasks.Objective{i}"); // Get the class containing the method
                MethodInfo method = t.GetMethod("Run"); // Get the executable method of the class
                try{
                method.Invoke(null, null); // invoke the method
                } catch {Console.WriteLine("Unhandled exception occured");} // Making sure unhandled exceptions don't stop everything
                Console.WriteLine("\n----------------\nEnd of objective {0}", i); // Informing the user the objective has ended
                Console.ReadLine(); // Not clearing console instantly
                Console.Clear(); // Clear the console after each objective for a fresh start
            }
        }
        static void Main(string[] args)
        {
            RunEmAll();
        }
    }
}
