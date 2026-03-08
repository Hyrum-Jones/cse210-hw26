using System;
using System.Diagnostics;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            name: "Breathing Activity",
            description: "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    { }

    public override void DoActivity()
    {
        Console.WriteLine();
        var sw = Stopwatch.StartNew();

        while (sw.Elapsed.TotalSeconds < Duration)
        {
            double remaining = Duration - sw.Elapsed.TotalSeconds;
            if (remaining <= 0) break;

            Console.Write("Breathe in... ");
            Countdown(ClampStep(4, remaining));
            Console.WriteLine();
            Console.WriteLine();

            remaining = Duration - sw.Elapsed.TotalSeconds;
            if (remaining <= 0) break;

            Console.Write("Breathe out... ");
            Countdown(ClampStep(6, remaining));
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}