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
            Console.WriteLine("Read or write files? (Read/Write)");
            string choice = (Console.ReadLine());
            choice = choice.ToLower();
            Console.WriteLine(choice);
            if (choice == "read")
            {
                Console.WriteLine("What's the filename?");
            }


            
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("Note.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Midagi on mädaaaaaaaa:");
                Console.WriteLine(e.Message);
            }

        }
    }
}
