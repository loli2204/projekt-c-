using System;

public class Game
{
    private Player player;
    private LocateSantaMiniGame locateSantaMiniGame;

    public Game(string playerName)
    {
        player = new Player(playerName);
        locateSantaMiniGame = new LocateSantaMiniGame();
    }

    public void StartGame()
    {
        Console.WriteLine("Välkommen till Julspelet!");
        player.DisplayStatus();
        Console.WriteLine("\nSpelet har startat...");

        locateSantaMiniGame.PlayMiniGame();

    }
}
