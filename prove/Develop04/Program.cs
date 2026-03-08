using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Mindfulness App";
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("-------------------");
            Console.WriteLine("1) Breathing Activity");
            Console.WriteLine("2) Reflection Activity");
            Console.WriteLine("3) Listing Activity");
            Console.WriteLine("4) Quit");
            Console.Write("Select a choice from the menu: ");

            string? choice = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(choice)) continue;

            Activity? activity = choice.Trim() switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectionActivity(),
                "3" => new ListingActivity(),
                "4" => null,
                _ => null
            };

            if (choice.Trim() == "4")
            {
                Console.WriteLine("\nGoodbye!");
                return;
            }

            if (activity != null)
            {
                Console.Clear();
                activity.DoStartingMessage();
                activity.DoActivity();
                activity.DoEndingMessage();
            }
            else
            {
                Console.WriteLine("\nInvalid option. Press any key...");
                Console.ReadKey(true);
            }
        }
    }
}