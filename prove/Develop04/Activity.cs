using System;
using System.Diagnostics;
using System.Threading;

public abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    protected Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    public int Duration => _duration;
    public string Name => _name;

    public void DoStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        _duration = ReadPositiveInt("How long, in seconds, would you like your session to be? ");

        Console.WriteLine("\nGet ready...");
        SpinnerAnimation(3);
    }

    public void DoEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        SpinnerAnimation(2);
        Console.WriteLine($"\nYou have completed the {_name} for {_duration} seconds.");
        SpinnerAnimation(3);
    }

    public abstract void DoActivity();

    protected void SpinnerAnimation(int durationSeconds)
    {
        char[] frames = new[] { '|', '/', '-', '\\' };
        var sw = Stopwatch.StartNew();
        int i = 0;
        while (sw.Elapsed.TotalSeconds < durationSeconds)
        {
            Console.Write($"\r{frames[i % frames.Length]} ");
            Thread.Sleep(100);
            i++;
        }
        Console.Write("\r  \r");
    }

    protected void Countdown(int countFrom)
    {
        for (int i = countFrom; i >= 1; i--)
        {
            string s = i.ToString();
            Console.Write(s);
            System.Threading.Thread.Sleep(1000);

            Console.Write(new string('\b', s.Length));  
            Console.Write(new string(' ', s.Length));   
            Console.Write(new string('\b', s.Length));  
        }
    }

    private int ReadPositiveInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? s = Console.ReadLine();
            if (int.TryParse(s, out int val) && val > 0) return val;
            Console.WriteLine("Please enter a positive whole number.");
        }
    }

    protected int ClampStep(int preferredSeconds, double remainingSeconds)
    {
        int r = (int)Math.Ceiling(remainingSeconds);
        return Math.Max(1, Math.Min(preferredSeconds, r));
    }
}