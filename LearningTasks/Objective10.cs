using System;
using System.IO;

/*
Objective 10: Key learning points
Understand serial files
• Serial files store data with no order to the data maintained.
• To search data from a serial file you begin at the start of the file and read all the data until the item
is found.
• Data cannot be deleted from a serial file without creating a new file and copying all the data except
the item you want to delete.
• Data cannot be changed in a serial file without creating a new file, copying all the data across to a
new file, inserting the change at the appropriate point.
• Data can be appended (added to the end) to a serial file.
• A file can be open for reading or writing, but not reading and writing at the same time.
• Serial files are quite limiting, but are useful for simple data sets and configuration files. Other types
of files include: sequential files where order of the data is maintained, index sequential files for
large data sets and random files which allow you to access any item without searching through the
file from the start.
*/

namespace LearningTasks
{
    class Objective10
    {
        private static string file = "Objective10File.txt";
        private static void Write()
        {
            // Open a text file for writing
            StreamWriter writer = new StreamWriter(file);

            // Write the data to the file
            writer.WriteLine("This is a simple way to save data"); //(and a bad one)
            writer.WriteLine("one line at a time");

            // Empty buffer & close the file
            writer.Close();
            Console.WriteLine("File Created");
        }

        private static void Read()
        {
            StreamReader r = new StreamReader(file);
            string line;
            do
            {
                // Read data from the file
                line = r.ReadLine();
                Console.WriteLine(line);
            }
            // Check if end of file
            while (line != null); // 'null' means nothing here

            // Close the file
            r.Close();
        }
        public static void Run()
        {   
            Write();
            Read();
        }
    }
}