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
        private static int i;

        static void Main(string[] args)
        {
            string folderpath = @"c:\Markmed";

            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(folderpath))
                {
                    Console.WriteLine("Folder 'Markmed found ");                    
                }
                else
                {
                    // Try to create the directory.
                    DirectoryInfo di = Directory.CreateDirectory(folderpath);
                    Console.WriteLine("Folder 'Markmed' was created successfully at {0}.", Directory.GetCreationTime(folderpath));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            


            DirectoryInfo d = new DirectoryInfo(@"\Markmed"); //Your Folder
                FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files
                Console.WriteLine("Files in folder: ");
                foreach (FileInfo file in Files)
                {
                    Console.WriteLine(file.Name);
                }

            while (i == 0)
            {

                Console.WriteLine("What's the filename?");
                var filename = Console.ReadLine();
                string curFile = @"c:\Markmed\" + filename;
                Console.WriteLine(File.Exists(curFile) ? "File exists." : "File does not exist.");



                Console.WriteLine("Select operation (new/read/delete)");
                var choice = Console.ReadLine();
                


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

                else if (choice == "new")
                {
                    string path = @"c:\Markmed\" + filename;
                    if (!File.Exists(path))
                    {
                        // Create a file to write to.
                        using (StreamWriter sw = File.CreateText(path)) 
                        Console.WriteLine("File " + filename + " created");
                    }

                    using (StreamWriter sw = File.AppendText(path))
                    {
                        Console.WriteLine("Start typing, press enter when done");
                        string WritingSession = Console.ReadLine();
                        sw.WriteLine(WritingSession);
                    }
                }
                else
                {
                    Console.WriteLine("Try again");
                    int i = 1;
                }
            }
        }
    }
}


