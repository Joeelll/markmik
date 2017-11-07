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
<<<<<<< HEAD

            }
<<<<<<< HEAD

            Console.WriteLine("");

            DirectoryInfo d = new DirectoryInfo(@"C:\markmed");//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files
            string str = "";
            foreach (FileInfo file in Files)
            {
                Console.WriteLine(file.Name);
<<<<<<< HEAD
            }
<<<<<<< HEAD

=======
=======
            }

>>>>>>> parent of 30e9259... Merge branch 'master' of https://github.com/Joeelll/markmik
>>>>>>> 1996f41e494aa2afaa4151c39eaf4e1df5f1834b
=======
>>>>>>> parent of 85327b1... re
=======
            }
>>>>>>> parent of 85327b1... re
        }
    }
}
