TestEncode(new string[] {});
TestEncode(new string[] {"Td", "8c", "Ks"});
TestEncode(new string[] {"Qh", "5h", "Ad"});
TestEncode(new string[] {"8c", "Ks", "Td"});
TestEncode(new string[] {"Qh", "Ad", "5h"});
Console.WriteLine();

TestDecode(new int[] {});
TestDecode(new int[] {7, 22, 51});
TestDecode(new int[] {13, 30, 37});
TestDecode(new int[] {7, 51, 22});
TestDecode(new int[] {13, 37, 30});
static void TestEncode(string[] cards)
{
    int[] cardsEncode = Encode(cards);

    for(int ind = 0; ind < cardsEncode.Length; ind++)
        Console.Write($"{cardsEncode[ind]} | ");
    Console.WriteLine();
}


static void TestDecode(int[] cards)
{
    string[] cardsDecode = Decode(cards);

    for(int ind = 0; ind < cardsDecode.Length; ind++)
        Console.Write($"{cardsDecode[ind]} | ");
    Console.WriteLine();
}

static int[] Encode(string[] cards) 
{
    int[] result = new int[cards.Length];
    
    for(int index = 0; index < cards.Length; index++)
    {
        Card card = new Card(cards[index]);
        result[index] = card.Id;
    }
        
    Array.Sort(result);

    return result;
}
  
static string[] Decode(int[] cards) 
{
    string[] result = new string[cards.Length];
    Card[] card = new Card[cards.Length];


    for(int ind = 0; ind < cards.Length; ind++)
        card[ind] = new Card(cards[ind]);

    Array.Sort(card);
    for(int ind = 0; ind < cards.Length; ind++)
        result[ind] = card[ind].FaceValue + card[ind].Suit;
    
    /* Sort
    https://www.c-sharpcorner.com/article/sort-array-list-of-objects-in-c-sharp-comparable-and-comperator/
    https://docs.microsoft.com/en-us/troubleshoot/developer/visualstudio/csharp/language-compilers/use-icomparable-icomparer
    IComparer
    */

    return result;
}


public class Card : IComparable<Card>
{
    public string Suit { get; set; }
    public string FaceValue { get; set; }
    public int Id { get; set; }

    public Card(string card)
    {
        this.Suit = card[0].ToString();
        this.FaceValue = card[1].ToString();
        this.Id = GetCardNumber(this.Suit) + (13 * GetSuitNumber(this.FaceValue));
    }

    public Card(int card)
    {
        this.Suit = GetSuit(card);
        this.FaceValue = GetCardValue(card);
        this.Id = card;
    }

    public int CompareTo(Card other)
    {
        if(other == null) return 1;
        if(this.Id > other.Id) return 1;
        else if(this.Id < other.Id) return -1;
        else return 0;
    }

    static string GetSuit(int number)
    {
        if(number < 13) return "c";
        if(number < 26) return "d";
        if(number < 39) return "h";
        return "s"; // default s
    }

    static string GetCardValue(int number)
    {
        int position = number % 13;
        string card = position switch
        {
            0 => "A",
            9 => "T",
            10 => "J",
            11 => "Q",
            12 => "K",
            _ => (position + 1).ToString()
        };

        //card += GetSuit(number).ToString();
        return card;
    }

    static int GetSuitNumber(string suit)
    {
        if(suit == "c") return 0;
        if(suit == "d") return 1;
        if(suit == "h") return 2;
        return 3; // default s
    }
    static int GetCardNumber(string card)
    {
        if(card == "A") return 0;
        if(card == "T") return 9;
        if(card == "J") return 10;
        if(card == "Q") return 11;
        if(card == "K") return 12;

        return Convert.ToInt32(card) - 1; // default 2 to 9 
    }
}