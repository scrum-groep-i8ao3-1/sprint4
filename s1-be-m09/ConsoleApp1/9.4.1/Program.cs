using System;
using System.Timers;

public class Example
{
    public static int maximumteller = 1;
    private static System.Timers.Timer aTimer;
    public static string teller = "";
    public static void Main()
    {
        SetTimer();
        Console.WriteLine("The application started at {0:HH:mm:ss.fff}", DateTime.Now);
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

        int maximumgetal = 20;
        if (maximumteller <= maximumgetal)
        {
            Console.Clear();
            teller += "*";
            Console.Write(teller);
            maximumteller += 1;            
        } 
        else
        {
            Console.WriteLine(" ");
            aTimer.Stop();
        }
    }

}
