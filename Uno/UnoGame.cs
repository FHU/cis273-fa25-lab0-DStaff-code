namespace Uno;

public class UnoGame
{
    public List<Player> Players { get; set; } = new List<Player>();
    public List<Card> DrawStack { get; set; } = new List<Card>();
    public List<Card> DiscardStack { get; set; } = new List<Card>();
    public Color CurrentColor { get; set; }

    public void StartGame()
    {
        // Example: shuffle deck, deal cards, etc.
        Console.WriteLine("Game starting with " + Players.Count + " players!");
    }
}