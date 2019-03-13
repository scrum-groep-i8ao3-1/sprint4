using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1
{
    class Program
    {

        //nagekeken door danny
        //gemaakt door danny
        static void Main(string[] args)
        {
            Console.WriteLine("voer de naam van de text bestand in (zonder txt)? : ");
            string input = Console.ReadLine();
            string path = @"E:\scrum\sprint4\s1-be-m09\9.1\9.1\";
            path += input;
            path += ".txt";
            Console.WriteLine(path);
            Console.ReadKey();
            if (File.Exists(path))
            {
                    Console.WriteLine("het " +
                        "document bestaat al, wilt u er naar toe schrijfen");
                    string antwoord = Console.ReadLine();
                    if (antwoord == "ja")
                    {
                        Console.WriteLine("wat wilt u naar het bestand schrijfen? : ");
                        string schrijfennaar = Console.ReadLine();
                    System.IO.File.WriteAllText(path, schrijfennaar);
                    System.Environment.Exit(1);
                    }
                    else
                    {
                        Console.WriteLine("het bestand word niet overschreven niet");
                        Console.ReadKey();
                        System.Environment.Exit(1);

                    }
            }
            else
            {
                Console.WriteLine("file bestaat niet");
                Console.ReadLine();
                System.Environment.Exit(1);
            }
            }
        }
}
