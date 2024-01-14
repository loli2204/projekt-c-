class Program
{
    static void Main()
    {
        Console.Write("Ange ditt namn: ");
        string playerName = Console.ReadLine();

        Game game = new Game(playerName);
        game.StartGame();
    }
}
