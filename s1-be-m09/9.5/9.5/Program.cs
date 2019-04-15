using System;
using System.Threading;
using System.Timers;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Writing_to_a_Text_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[1];

            Console.WriteLine("geef tijd/datum om u clock tezetten");

            for (int i = 0; i < 1; i++)
            {
                names[i] = Console.ReadLine();
            }

            //schrijft naar het mapje toe
            StreamWriter SW = new StreamWriter(@"C:\Users\mylok\source\repos\4\4\bin\Debug\hallo");

            for (int i = 0; i < 1; i++)
            {
                SW.WriteLine(names[i]);
            }

            SW.Close();

            StreamReader();


        }
        static void StreamReader()
        {
            string[] names2 = new string[1];

            //leest wat er in het mapje staat
            StreamReader SR = new StreamReader(@"C:\Users\mylok\source\repos\4\4\bin\Debug\hallo");


            for (int i = 0; i < 1; i++)
            {
                names2[i] = SR.ReadLine();
            }

            SR.Close();

            Console.WriteLine("Hier is wat je hebt geschreven");

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine(names2[i]);
            }

            string[] names = names2[1].Split(';');

            while (true)
            {
                if (names[1] = DateTime.Today.ToString())
                {
                    //speelt geluid af
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer("C:/Users/mylok/OneDrive/Documents/wolf.wav");
                    player.Play();
                    Console.WriteLine("Wolf");
                    Console.ReadLine();
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
