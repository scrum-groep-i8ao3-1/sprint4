using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Data;
using System.Drawing;

namespace _9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wilt u een Duits Stoplicht zien of een Nederlands stoplicht?");
            string keuze = Convert.ToString(Console.ReadLine());
            string keus = keuze.ToLower();
            if (keus == "nederlands")
            {
                Console.Clear();
                NLstop();
            }
            else
            {
                Console.Clear();
                DEstop();
            }
            Console.ResetColor();
            Console.WriteLine("Klaar");
            Console.ReadKey();
        }
        private static void NLstop()
        {
            for (int i = 0; i < 5; i++)
            {
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Rood");
                System.Threading.Thread.Sleep(5000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Groen");
                System.Threading.Thread.Sleep(5000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Oranje");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
            }
        }
        private static void DEstop()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Rood");
                System.Threading.Thread.Sleep(5000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Oranje");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Groen");
                System.Threading.Thread.Sleep(5000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Oranje");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
            }
        }
    }
}
