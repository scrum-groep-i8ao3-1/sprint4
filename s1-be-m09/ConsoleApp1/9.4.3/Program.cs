using System;
using System.Timers;

public class Example
{
    public static int maximumteller = 0;
    private static System.Timers.Timer aTimer;
    public static string teller = string.Empty;
    public static string userK = "";
    public static double procent = 0;
    public static int maximumgetal = 0;
    public static void Main()
    {
        Console.WriteLine("vul in welk karakter u wult gebruiken: ");
        userK = Convert.ToString(Console.ReadLine());
        Console.WriteLine("hoeveel van deze karakters wild u hebben: ");
        maximumgetal = Convert.ToInt32(Console.ReadLine());
        maximumgetal -= 1;
        SetTimer();
        Console.WriteLine(" ");
        Console.ReadLine();
        aTimer.Stop();
        aTimer.Dispose();
    }

    private static void SetTimer()
    {
        
        // Create a timer with a two second interval.
        aTimer = new System.Timers.Timer(500);
        // Hook up the Elapsed event for the timer. 
        aTimer.Elapsed += OnTimedEvent;
        aTimer.AutoReset = true;
        aTimer.Enabled = true;
    }

    private static void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
        
        Console.Clear();
        if (maximumteller <= maximumgetal)
        {
            procent += ((maximumteller / maximumgetal) * 100);
            Console.WriteLine("Karakter: " + userK);
            Console.WriteLine("Hoeveelheid Karakters: "+ (maximumgetal + 1));
            Console.Write(procent + "% ");
            Console.WriteLine(Convert.ToString(teller));
            maximumteller += 1;
        }
        else
        {
            Console.WriteLine("Karakter: " + userK);
            Console.WriteLine("Hoeveelheid Karakters: " + (maximumgetal + 1));
            Console.WriteLine(teller);
            Console.WriteLine("Done.");
            aTimer.Stop();
        }
    }

}
