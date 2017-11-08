using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eikannata
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"\Markmed"); //Your Folder
            FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files
            Console.WriteLine("Files in folder: ");
            foreach (FileInfo file in Files)
            {
                Console.WriteLine(file.Name);
            }

            Console.WriteLine("Whaddya wanna do? (read/write to/new file)");
            var choice = Console.ReadLine();
            Console.WriteLine("Which file you do want to select?");
            var filename = Console.ReadLine();
            

            if (choice == "read")
            {
                try
                {
                    // Open the text file using a stream reader.
                    string[] lines = System.IO.File.ReadAllLines(@"C:\Markmed\" + filename);

                    // Display the file contents by using a foreach loop.
                    System.Console.WriteLine("Opening " + filename);
                    foreach (string line in lines)
                    {
                        // Use a tab to indent each line of the file.
                        Console.WriteLine("\t" + line);
                    }

                    // Keep the console window open in debug mode.
                    Console.WriteLine("Press any key to exit.");
                    System.Console.ReadKey();
                }
                catch (Exception e)
                {
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(e.Message);
                }
            }

            else if (choice == "write to")
            {
                string path = @"c:\Markmed\" + filename;
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("--New writing session started--");
                    sw.WriteLine("\n");
                    Console.WriteLine("Start typing, press enter when done");
                    string WritingSession = Console.ReadLine();
                    sw.WriteLine(WritingSession);
                }

                // Open the file to read from.
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }

            else if (choice == "new file")
            {
                string path = @"c:\Markmed\" + filename;
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path)) ;
                    Console.WriteLine("File " + filename + " created");
                }
            }
        }
    }
}
