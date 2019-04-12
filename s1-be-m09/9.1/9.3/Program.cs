using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _9._3opdacht
{
    class Program
    {
        private static System.Timers.Timer aTimer;
        public static Random rnd = new Random();
        static void Main(string[] args)
        {
            //Past de grote van de window aan
            SetTimer();
            Console.ReadKey();
        }
        private static void SetTimer()
        {
            // Maakt een timer die elke 1,5 seconden afgaat
            aTimer = new System.Timers.Timer(500);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true; ;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            int nummer1 = rnd.Next(1, 100); //yy
            int nummer2 = rnd.Next(1, 100); //xx
            int nummer3 = rnd.Next(1, 4);

            switch (nummer3)
            {
                case 1:
                    //kleur = "blauw";
                    display(nummer1, nummer2, " ", 1);
                    break;
                case 2:
                    //kleur = "Rood";
                    display(nummer1, nummer2, " ", 2);
                    break;
                case 3:
                    //kleur = "Geel";
                    display(nummer1, nummer2, " ", 3);
                    break;
            }
        }
        public static void display(int x, int y, string s, int kleur)
        {
            Console.Clear();
            switch (kleur)
            {
                case 1:
                    //blauw
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case 2:
                    //rood
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case 3:
                    //geel
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                default:
                    Console.SetCursorPosition(x, y);
                    Console.Write("error-geen kleur");
                    break;
            }
            Console.SetCursorPosition(x, y);
            Console.Write(s);
            Console.BackgroundColor = ConsoleColor.Black;
            return;
        }
    }
}