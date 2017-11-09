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
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }


            Console.WriteLine("Praegused märkmed on: ");

            DirectoryInfo d = new DirectoryInfo(@"C:\markmed");//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files
            foreach (FileInfo file in Files)
            {
                Console.WriteLine(file.Name);
            }

            Console.WriteLine("Mida te soovite teha? (New/Read/Delete)");
            string vastus = Console.ReadLine();

            if (vastus == "New")
            {

            }

            if (vastus == "Read")
            {
            }

            if (vastus == "Delete")
            {

            }

        }
          
    }
}
