/*
The digital Realms of C# have playing cards like ours but with some differences. Each card has a color
(red, green, blue, yellow) and a rank (the numbers 1 through 10, followed by the symbols $, %, ^, and &).
The third pedestal requires that you create a class to represent a card of this nature.

• Define enumerations for card colors and card ranks.
• Define a Card class to represent a card with a color and a rank, as described above.
• Add properties or methods that tell you if a card is a number or symbol card (the equivalent of a
face card).
• Create a main method that will create a card instance for the whole deck (every color with every
rank) and display each (for example, “The Red Ampersand” and “The Blue Seven”).
• Answer this question: Why do you think we used a color enumeration here but made a color class
in the previous challenge?
*/

Console.WriteLine("Hello, World!");

// Create a card instance

//CardColor color = CardColor.red;
//CardRank rank = CardRank.One;



foreach (CardColor i in Enum.GetValues(typeof(CardColor)))
{
    foreach (CardRank j in Enum.GetValues(typeof(CardRank)))
    {
        Card card = new Card(i,j);
        Console.Write($"The {card.color} {card.rank}");
        if (Card.isNum(card.rank)==false)
        {
            Console.Write(" Face card ");
        }
        Console.WriteLine("");
    }
}

public class Card
{
    public CardColor color { get; }
    public CardRank rank { get; }

    public Card (CardColor _color,CardRank _rank)
    {
        color = _color;
        rank = _rank;
    }

    public static bool isNum(CardRank cRank)
    {
        if (cRank == CardRank.DollarSign || cRank == CardRank.Percent || cRank == CardRank.Caret || cRank == CardRank.Ampersand)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}

public enum CardColor { Red, Green, Blue, Yellow}
public enum CardRank { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, DollarSign, Percent, Caret, Ampersand }