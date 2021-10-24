using System;
using System.Collections.Generic;

/*
Objective 9: Key learning points
Understand arrays and lists
• Arrays are variables that have multiple elements, all of the same data type.
• Arrays are a static data structure because the size of the array does not change when the program
is running.
• Lists are dynamic data structures because the size of the list changes when the program is running.
• An array or list has an identifier: the name of the array.
• An array or list has an index which points to one element of the array/list.
• Indexes start at 0.
• An array has multiple elements: the data stored in it.
• Arrays can be single dimension (one set of data) or be multi-dimension (having more than one set
of data)
• Lists have methods that are operations that can be performed on the list with no additional code
written by the programmer.
*/

namespace LearningTasks
{
    class Objective9
    {
        public static void Run()
        {
            // create a new list
            List<string> inventory = new List<string>();

            // Add items to the list
            inventory.Add("torch");
            inventory.Add("gold coin");
            inventory.Add("key");

            // Remove items from the list
            inventory.Remove("gold coin");

            // Sort the items into alphabetical order
            inventory.Sort();

            // Output all the items in the list
            Console.WriteLine("This is currently in your inventory: " + string.Join(", ", inventory) + "\ntype the name of the item to drop");
            string ToBeDropped = Console.ReadLine().ToLower();
            if (!inventory.Contains(ToBeDropped)) Console.WriteLine("Item not in inventory");
            else {
                inventory.Remove(ToBeDropped);
                Console.WriteLine("Successfully dropped item '{0}'", ToBeDropped);
            }
        }
    }
}