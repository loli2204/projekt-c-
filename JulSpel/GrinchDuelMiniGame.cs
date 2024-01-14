using System;
using System.Threading;

public class GrinchDuelMiniGame
{
    public void PlayMiniGame()
    {
        Console.WriteLine("Du står nu öga mot öga med Grinchen. Det är dags för en duell!");
        Console.WriteLine("Tryck på Enter så snabbt som möjligt när du är redo att slåss.");

        Console.ReadLine(); // Vänta på spelarens Enter-tryck

        // Starta duell
        bool playerWins = DuelWithGrinch();

        // Visa resultatet av duellen
        if (playerWins)
        {
            Console.WriteLine("Grattis! Du har besegrat Grinchen och räddat julen!");
        }
        else
        {
            Console.WriteLine("Tyvärr, Grinchen var för snabb. Bättre lycka nästa gång!");
        }

        // Avslutande text och meddelande att julen är räddad
        Console.WriteLine("\nTack för att du spelade! Julen är nu officiellt räddad. Hoppas du hade roligt!");
        Console.WriteLine("Tryck på Enter för att avsluta...");

        Console.ReadLine(); // Vänta på spelarens Enter-tryck för att avsluta spelet
    }

    private bool DuelWithGrinch()
    {
        Random random = new Random();
        int grinchReactionTime = random.Next(1000, 3000); // Grinchens reaktionstid mellan 1 och 3 sekunder

        Console.WriteLine("3...");
        Thread.Sleep(1000);
        Console.WriteLine("2...");
        Thread.Sleep(1000);
        Console.WriteLine("1...");
        Thread.Sleep(1000);
        Console.WriteLine("Slåss!");

        DateTime startTime = DateTime.Now;
        Console.ReadLine(); // Spelaren trycker på Enter

        DateTime endTime = DateTime.Now;
        double playerReactionTime = (endTime - startTime).TotalMilliseconds;

        Console.WriteLine($"Din reaktionstid: {playerReactionTime} ms");
        Console.WriteLine($"Grinchens reaktionstid: {grinchReactionTime} ms");

        // Jämför reaktionstider och avgör vinnare
        return playerReactionTime < grinchReactionTime;
    }
}
