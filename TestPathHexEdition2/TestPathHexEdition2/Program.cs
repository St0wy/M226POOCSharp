using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPathHexEdition2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using(StreamReader reader = new StreamReader(@"C:\Users\HUBERF_INFO\Downloads\salut.txt"))
                {
                    string line;

                    Console.Write("Contenu : \n");
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erreur lors de la lecture du fichier !");
            }

            Console.ReadKey();
        }
    }
}
