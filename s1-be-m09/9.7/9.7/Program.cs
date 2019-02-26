using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._7
{
    class Program
    {
        //gemaakt door danny
        //gebruik maximaal 6 personen
        //goed gekeurd door jairo
        //werkt goed !
        public static string resultaat = "";
        static void Main(string[] args)
        {
            /*+--+--+--+--+--+--+--+--+--+--+--+
|  |  |  |  |  |  |  |  |  |  |  |
+--+--+--+--+--+--+--+--+--+--+--+
|  |  |  |  |  |  |  |  |  |  |  |
+--+--+--+--+--+--+--+--+--+--+--+
|  |  |  |  |  |  |  |  |  |  |  |
+--+--+--+--+--+--+--+--+--+--+--+
|  |  |  |  |  |  |  |  |  |  |  |
+--+--+--+--+--+--+--+--+--+--+--+
|  |  |  |  |  |  |  |  |  |  |  |
+--+--+--+--+--+--+--+--+--+--+--+
|  |  |  |  |  |  |  |  |  |  |  |
+--+--+--+--+--+--+--+--+--+--+--+*/
            string path = @"E:\scrum\sprint4\s1-be-m09\9.7\9.7\namen.txt.txt";
            StreamReader sr = new StreamReader(path);
            var lineCount = File.ReadLines(path).Count(); // het nummer hoeveel lines er heeft [ wil je er 1 toevoegen]
            Console.WriteLine("+--+--+--+--+--+--+--+--+--+--+--+"); //bovenkant van tabel
            for (int i = 0; i < lineCount; i++)
            {
                resultaat = "";
                string lijn = sr.ReadLine();
                string[] array = lijn.Split(' ');
                string naam = array[0];
                string datum = array[1];
                string today = DateTime.Today.ToString("dd/MM/YYYY");
                string deflayout = "|" + naam + "|";
                resultaat += deflayout;
                    for (int a = 0; a < 10; a++)
                    {
                    string[] splitatie = datum.Split('-'); // maakt bvb 24-02-2002 naar 24 02 2002
                    string dag = splitatie[0]; //dag //werkt 100 %
                    string maand = splitatie[1]; //maand //werkt 100 %
                    string jaar = splitatie[2]; //jaar //werkt 100 %
                    jaar = Convert.ToString((Convert.ToInt32(jaar) + a)); //voeg i toe aan resultaat waardoor het dus x[i] aantallen word
                    string invoer = stringsnaardatum(dag,maand,jaar);
                    DateTime uitdatum = Convert.ToDateTime(invoer);
                    string outvoer = Convert.ToString(uitdatum.DayOfWeek);
                    resultaat += outvoer + "|";
                    deflayout += resultaat;
                    }
                Console.WriteLine(resultaat);
                Console.WriteLine("+--+--+--+--+--+--+--+--+--+--+--+");
            }
            Console.ReadKey();
        }
        public static string stringsnaardatum(string dag,string maand,string jaar)
        {
            string datum = dag+"-"+maand+"-"+jaar;
            return datum;
        }
    }
}
