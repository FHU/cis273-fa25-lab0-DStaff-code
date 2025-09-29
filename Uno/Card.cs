namespace Uno;

public enum CardType
{
    Number, Wild, Draw2, WildDraw4, Skip, Reverse
}

public enum Color
{
    Red, Yellow, Blue, Green, Wild
}

public class Card
{
    public CardType Type { get; set; }
    public Color Color { get; set; }
    public int? Number { get; set; }

public static bool PlaysOn(Card card1, Card card2)
{
    // Wilds can always be played
    if (card1.Type == CardType.Wild || card1.Type == CardType.WildDraw4)
        return true;

    // If the top card is a wild, anything can be played
    if (card2.Type == CardType.Wild || card2.Type == CardType.WildDraw4)
        return true;

    // Same color always works
    if (card1.Color == card2.Color)
        return true;

    // Numbers match
    if (card1.Type == CardType.Number && card2.Type == CardType.Number 
        && card1.Number == card2.Number)
        return true;

    // Special card types match (Skip on Skip, Reverse on Reverse, etc.)
    if (card1.Type == card2.Type && card1.Type != CardType.Number)
        return true;

    return false;
}

    public override string ToString()
    {
        if (Type == CardType.Number)
        {
            return $"{Color} {Number}";
        }
        else if (Type == CardType.Wild)
        {
            return "Wild";
        }
        else if (Type == CardType.WildDraw4)
        {
            return "WildDraw4";
        }
        else
        {
            return $"{Color} {Type}";
        }
    }
}