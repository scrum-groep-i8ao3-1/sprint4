
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Opdracht_9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vraagt hoe het document genoemd moet worden.
            Console.WriteLine("Hoe moet het document heten?");
            string fileName = Console.ReadLine();
            string file = Environment.CurrentDirectory + "\\" + fileName + ".txt";

            //Kijkt of er al een bestand is met die naam.
            if (File.Exists(file))
            {
                Console.Clear();
                Console.WriteLine($"Er is al een bestand genaamd: {fileName}, Wil je het laten overschijven? (y/n)");
                string userInput = Console.ReadLine();
                if (userInput.Contains("n"))
                {
                    Environment.Exit(1);
                }
            }
            //Vraagt de gebruiker om iets te schrijven en slaat het op.
            Console.Clear();
            Console.WriteLine("Type een text en druk op enter om het op te slaan.");
            using (StreamWriter text = File.CreateText(file))
            {
                text.WriteLine(Console.ReadLine());
            }
            System.Diagnostics.Process.Start(file);
            Environment.Exit(1);
        }
    }
}