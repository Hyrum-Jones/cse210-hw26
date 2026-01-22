using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {   
        //1/15/26 in class group assignment

        // Console.WriteLine("Give me a verb ");
        // string verb = Console.ReadLine();
        // string verbCaps = verb.ToUpper();

        // Console.WriteLine("Give me a noun ");
        // string noun = Console.ReadLine();
        // string nounCaps = noun.ToUpper();

        // Console.WriteLine("Give me an adjective");
        // string adjective = Console.ReadLine();
        // string adjectiveCaps = adjective.ToUpper();

        // Console.WriteLine($"Yesterday I tried to {verbCaps} in the school hallway and everyone started screaming. " +
        //                   $"Then the principal came running in holding a {nounCaps} like it was evidence. " +
        //                   $"Now I’m officially known as “the {adjectiveCaps} legend” and I can never show my face again.");

        //Personal Practice

        //Age group simulator
        // Console.WriteLine("What is your age? ");
        // string input = Console.ReadLine();
        // int age = int.Parse(input);

        // string ageGroup = "";


        // if (age < 13)
        // {
        //     ageGroup = "Child";
        // }

        // else if (age >= 13 && age <= 17)
        // {
        //     ageGroup = "Teen";
        // }                  

        // else
        // {
        //     ageGroup = "Adult";
        // }

        // //Determines if the word A or AN is used
        // if (ageGroup == "Adult")
        // {
        //     Console.WriteLine($"Since you are {input}, that means you are an {ageGroup}!");  
        // }

        // else
        // {
        //     Console.WriteLine($"Since you are {input}, that means you are a {ageGroup}!");
        // }

        //In class notes 1/20/26
        // int number = 10;

        // if (number == 0)
        // {
        //     Console.WriteLine($"Your number is 0");    
        // }

        // else if (number >= 10 || number <= -10)
        // {
        //     Console.WriteLine($"Your number {number} is a multi digit");
        // }

        // else
        // {
        //     Console.WriteLine("Single digit");
        // }

        // string response = "yes";

        // while (response == "yes")
        // {
        //     Console.Write("Do you want to continue? ");
        //     response = Console.ReadLine();
        // }

        // Console.WriteLine("Done");

        //foreach loop
        // List<String> words = new List<string>();
        // words.Add("cold");
        // words.Add("snow");
        // words.Add("soccer");

        // for (int i = words.Count - 1; i >= 0; i--)
        // {
        //     Console.WriteLine(words[i]);
        // }

        // foreach (string word in words)
        // {
        //     Console.WriteLine(word);
        // }

        //for loop
        // for(int i = 0; i < 10; i++)
        // {
        //     Console.WriteLine(i);
        // }

        // for(int i = 10; i > 0; i--)
        // {
        //     Console.WriteLine(i);
        // }

        void DisplayMessage(string name)
        {
            Console.WriteLine($"");
        }

    }
}