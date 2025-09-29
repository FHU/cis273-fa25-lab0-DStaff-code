namespace Uno;

public class Player
{
    public string Name { get; set; } = "";
    public List<Card> Hand { get; set; } = new List<Card>();

    // Does player have at least one card that plays on 'card'?
    public bool HasPlayableCard(Card card)
    {
        foreach (var c in Hand)
        {
            if (Card.PlaysOn(c, card))
                return true;
        }
        return false;
    }

    // Return first playable card or null
    public Card GetFirstPlayableCard(Card card)
    {
        foreach (var c in Hand)
        {
            if (Card.PlaysOn(c, card))
                return c;
        }
        return null;
    }

    // Which color appears most in the hand?
    public Color MostCommonColor()
    {
        // Count colors
        int red = 0, yellow = 0, blue = 0, green = 0, wild = 0;
        foreach (var c in Hand)
        {
            if (c.Color == Color.Red) red++;
            else if (c.Color == Color.Yellow) yellow++;
            else if (c.Color == Color.Blue) blue++;
            else if (c.Color == Color.Green) green++;
            else if (c.Color == Color.Wild) wild++;
        }

        // Decide order: Red, Yellow, Blue, Green, Wild
        int max = Math.Max(Math.Max(Math.Max(Math.Max(red, yellow), blue), green), wild);

        if (red == max) return Color.Red;
        if (yellow == max) return Color.Yellow;
        if (blue == max) return Color.Blue;
        if (green == max) return Color.Green;
        return Color.Wild;
    }
}