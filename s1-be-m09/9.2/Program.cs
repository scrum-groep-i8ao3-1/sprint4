using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wilt u een Duits of Nederlands stoplicht zien?");
            string keuze = Convert.ToString(Console.ReadLine());
            keuze.ToLower();
            Console.Clear();
            if (keuze == "nederlands")
            {
                NLstop();
            }
            if (keuze == "duits")
            {
                DEstop();
            }
            Console.ResetColor();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Dit was de demonstratie.");
            Console.ReadLine();
        }
        private static void NLstop()
        {

            for (int i = 0; i < 5; i++)
            {


                rood();
                paal();

                slaap(5);
                reset();

                groen();
                paal();

                slaap(5);
                reset();

                oranje();
                paal();

                slaap(2);
                reset();
            }
        }


        private static void DEstop()
        {
            for (int i = 0; i < 5; i++)
            {

                rood();
                paal();

                slaap(5);
                reset();


                oranje();
                paal();

                slaap(2);
                reset();

                groen();
                paal();

                slaap(5);
                reset();

                oranje();
                paal();

                slaap(2);
                reset();
            }
        }
        static void oranje()
        {
            string kleur = "    ";
            string klein = "  ";
            string lang = "        ";

            Console.CursorLeft = 10;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(lang);
            grijs();
            
            Console.CursorLeft = 10;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write(klein);
            Console.CursorLeft = 12;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write(kleur);
            Console.CursorLeft = 16;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(klein);
            Console.CursorLeft = 10;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write(klein);
            Console.CursorLeft = 12;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write(kleur);
            Console.CursorLeft = 16;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(klein);
            Console.CursorLeft = 10;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(lang);

            grijs();
        }
        static void groen()
        {
            string kleur = "    ";
            string klein = "  ";
            string lang = "        ";

            Console.CursorLeft = 10;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(lang);

            grijs();
            grijs();
            
            Console.CursorLeft = 10;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write(klein);
            Console.CursorLeft = 12;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(kleur);
            Console.CursorLeft = 16;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(klein);
            Console.CursorLeft = 10;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write(klein);
            Console.CursorLeft = 12;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(kleur);
            Console.CursorLeft = 16;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(klein);
            Console.CursorLeft = 10;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(lang);
        }
        static void rood()
        {
            string kleur = "    ";
            string klein = "  ";
            string lang = "        ";

            Console.CursorLeft = 10;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(lang);
            Console.CursorLeft = 10;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write(klein);
            Console.CursorLeft = 12;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(kleur);
            Console.CursorLeft = 16;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(klein);
            Console.CursorLeft = 10;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write(klein);
            Console.CursorLeft = 12;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(kleur);
            Console.CursorLeft = 16;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(klein);
            Console.CursorLeft = 10;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(lang);

            grijs();
            grijs();
        }
        static void grijs()
        {
            string kleur = "    ";
            string klein = "  ";
            string lang = "        ";

            
            Console.CursorLeft = 10;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write(klein);
            Console.CursorLeft = 12;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(kleur);
            Console.CursorLeft = 16;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(klein);
            Console.CursorLeft = 10;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write(klein);
            Console.CursorLeft = 12;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(kleur);
            Console.CursorLeft = 16;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(klein);
            Console.CursorLeft = 10;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(lang);
        }
        static void paal()
        {
            for (int a = 0; a < 6; a++)
            {
                string paal = "    ";
                Console.CursorLeft = 12;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine(paal);
                Console.CursorLeft = 12;
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.WriteLine(paal);
            }
        }
        static void slaap(int seconden)
        {
            int tijd = seconden * 1000;
            System.Threading.Thread.Sleep(tijd);
        }
        static void reset()
        {
            Console.ResetColor();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}