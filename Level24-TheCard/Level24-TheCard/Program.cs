using System.Drawing;

Card[] myDeck = new Card[56];
int i = 0;
var teste = CardColors.Green;

foreach (CardColors color in Enum.GetValues(typeof(CardColors)))
{
    foreach (CardRanks rank in Enum.GetValues(typeof(CardRanks)))
    {
       
        Card aux = new Card(color, rank);
        myDeck[i] = aux;
        Console.WriteLine($"The {myDeck[i].Color} {myDeck[i].Rank}");
        i++;
        
    }   
   
}
public class Card{
    public CardColors Color { get; }
    public CardRanks Rank { get; }

    public Card(CardColors color, CardRanks rank)
    {
        this.Color = color;
        this.Rank = rank;
    }

    public bool IsSymbol()
    {
        bool isSymbol = this.Rank == CardRanks.DollarSign
                        || this.Rank == CardRanks.Percent
                        || this.Rank == CardRanks.Circumflex
                        || this.Rank == CardRanks.Ampersand;


        return isSymbol;
    }
    public bool IsDigit => !IsSymbol();
}

public enum CardColors { Red, Green, Blue, Yellow}
public enum CardRanks {One, Two, Three, Four, Five, Six, Seven, Eight,Nine, Ten, DollarSign, Percent, Circumflex, Ampersand}
