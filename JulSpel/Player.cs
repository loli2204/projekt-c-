public class Player
{
    public string Name { get; private set; }

    public Player(string name)
    {
        Name = name;
    }

    public void DisplayStatus()
    {
        Console.WriteLine($"Spelarens namn: {Name}");
    }
}
