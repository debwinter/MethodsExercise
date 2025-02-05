﻿namespace MethodsExercise
{
    public class Program
    {
        public static void MadLib()
        {
            Console.WriteLine("What is your name?");
            string? name = Console.ReadLine();

            Console.WriteLine($"Welcome to MadLibs, {name}! \n" +
                "Enter the first thing you can think of for each of the following.\n");

            Console.Write("PLURAL NOUN: ");
            string? pluralNoun = Console.ReadLine();

            Console.Write("COMMAND FOR A DOG (e.g. sit, stay, heel, etc.): ");
            string? dogCommand = Console.ReadLine();

            Console.Write("ADVERB: ");
            string? adverb = Console.ReadLine();

            Console.Write("FRACTION: ");
            string? fraction = Console.ReadLine();

            Console.Write("NOUN: ");
            string? noun = Console.ReadLine();

            Console.Write("VERB ENDING IN \"ING\": ");
            string? gerund = Console.ReadLine();

            Console.Write("ADVERB OF TIME (e.g. soon, later, yesterday, tonight, weekly, etc.): ");
            string? adverbOfTime = Console.ReadLine();

            Console.Write("VERB: ");
            string? verb = Console.ReadLine();

            Console.Write("ADJECTIVE: ");
            string? adjective = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Great job! You just wrote a classic song.\n" +
                "If you're ready to see it, type \"OK\": ");
            Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("\t\"YESTERDAY\" by The Beatles\n" +
                $"\t(rewritten by {name})\n");
            
            Console.WriteLine($"\t{adverbOfTime}\n" +
                $"\tAll my {pluralNoun} seemed so far away\n" +
                $"\tNow it looks as though they're here to {dogCommand}\n" +
                $"\tOh, I believe in {adverbOfTime}\n" +
                $"\n" +
                $"\t{adverb}\n" +
                $"\tI'm not {fraction} the man I used to be\n" +
                $"\tThere's a {noun} {gerund} over me\n" +
                $"\tOh, {adverbOfTime} came {adverb}\n" +
                $"\n" +
                $"\tWhy she had to {verb}\n" +
                $"\tI don't know, she wouldn't say\n" +
                $"\tI said something {adjective}\n" +
                $"\tNow I long for {adverbOfTime}");
        }

        static void Main(string[] args)
        {
            MadLib();
        }
    }
}
