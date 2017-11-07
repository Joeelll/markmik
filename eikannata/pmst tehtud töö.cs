using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open the text file using a stream reader.
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
    }
}
