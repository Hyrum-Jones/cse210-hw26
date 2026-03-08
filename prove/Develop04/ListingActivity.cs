using System;
using System.Collections.Generic;
using System.Diagnostics;

public class ListingActivity : Activity
{
    private readonly List<string> _prompts = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
        : base(
            name: "Listing Activity",
            description: "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    { }

    public override void DoActivity()
    {
        Console.WriteLine();

        var rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($" --- {prompt} ---\n");
        Console.Write("You may begin in: ");
        Countdown(5);
        Console.WriteLine();
        Console.WriteLine("Start listing! (press Enter after each item)");
        Console.WriteLine("(When time is up, I'll stop after your next entry.)\n");

        var items = new List<string>();
        var sw = Stopwatch.StartNew();

        while (sw.Elapsed.TotalSeconds < Duration)
        {
            Console.Write("> ");
            string? line = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(line))
            {
                items.Add(line.Trim());
            }
        }

        Console.WriteLine($"\nYou listed {items.Count} item(s).");
    }
}