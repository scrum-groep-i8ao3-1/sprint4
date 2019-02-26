using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._6
{
    class Program
    {
        //gemaakt door danny
        //nagekeken door jairo
        //goed gekeurd
        static void Main(string[] args)
        {
            Boolean jarig = false;
            string path = @"E:\scrum\sprint4\s1-be-m09\9.6\9.6\namen.txt.txt";
            string[,] ned = new string[4, 2]; //namen en datums [ned]
            StreamReader sr = new StreamReader(path);
            var lineCount = File.ReadLines(path).Count(); // het nummer hoeveel lines er heeft [ wil je er 1 toevoegen]
            for (int i = 0;i < lineCount; i++)
            {
                string lijn =sr.ReadLine();
                string[] array = lijn.Split(' ');
                string naam = array[0];
                string datum = array[1];
                string today = DateTime.Today.ToString("dd/MM");
                if (datum == today)
                {
                    Console.WriteLine(naam + "is jarig");
                    jarig = true;
                }

            }
            if(jarig == true)
            {
                string locatie = @"E:\scrum\sprint4\s1-be-m09\9.6\9.6\Happy_Birthday_to_You-osKLrBxqkuA.wav";
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(locatie);
                player.Play();
            }
            else
            {
                Console.WriteLine("er is niemand jarig ;{");
            }
            Console.ReadLine();
        }
    }
}
