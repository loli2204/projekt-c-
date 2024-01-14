using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

public class RepairSleighMiniGame
{
    private List<string> sleighParts;
    private List<string> assembledSleigh;

    public RepairSleighMiniGame()
    {
        sleighParts = new List<string> { "Hjul", "Lyktor", "GPS", "Säkerhetsbälte", "Dragrep", "Säck" };
        assembledSleigh = new List<string>();
    }

    public void PlayMiniGame()
    {
        Console.WriteLine("Nu står du framför den trasiga släden. Du måste bygga den för att fortsätta.");

        Console.WriteLine("Dessa delar behöver ordnas för att laga släden:");

        // Slumpa ordningen på delarna
        Random random = new Random();
        sleighParts = sleighParts.OrderBy(x => random.Next()).ToList();

        // Visa delarna och låt spelaren bygga ihop släden
        foreach (var part in sleighParts)
        {
            Console.Clear();
            Console.WriteLine("Tryck på en tangent för att lägga till delar i släden...");

            // Visa status för bygget
            Console.WriteLine("Bygger:");
            foreach (var assembledPart in assembledSleigh)
            {
                Console.WriteLine($" - {assembledPart}");
            }

            Console.WriteLine($"\nLägger till: {part}");
            Console.ReadKey(true); // True för att undvika att visa tangenttryckningen
            assembledSleigh.Add(part);
        }

        // Rensa konsolfönstret för att visa slutresultatet
        Console.Clear();

        // Visa status för bygget
        Console.WriteLine("Slutresultat:");

        if (CheckAssembly())
        {
            Console.WriteLine("Bra jobbat! Släden är nu lagad.");

            // Gå vidare till GrinchDuelMiniGame
            GrinchDuelMiniGame grinchDuelMiniGame = new GrinchDuelMiniGame();
            grinchDuelMiniGame.PlayMiniGame();
        }
        else
        {
            Console.WriteLine("Det verkar som om släden inte är ordentligt lagad. Försök igen!");
        }
    }

    private bool CheckAssembly()
    {
        // Kontrollera om släden är korrekt ihopsatt
        return sleighParts.SequenceEqual(assembledSleigh);
    }
}
