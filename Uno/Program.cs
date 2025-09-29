namespace Uno;

public class Program
{
    public static void Main(string[] args)
    {
        Card card1 = new Card { Type = CardType.Number, Color = Color.Red, Number = 10 };
        Card card2 = new Card { Type = CardType.Number, Color = Color.Blue, Number = 10 };
        Card card3 = new Card { Type = CardType.Skip, Color = Color.Red };

        Console.WriteLine(card1);  // "Red 10"
        Console.WriteLine(card2);  // "Blue 10"
        Console.WriteLine(card3);  // "Red Skip"

        Console.WriteLine(Card.PlaysOn(card1, card2)); // true (same number)
        Console.WriteLine(Card.PlaysOn(card1, card3)); // false
    }
}