TestEncode(new string[] {});
TestEncode(new string[] {"Td", "8c", "Ks"});
TestEncode(new string[] {"Qh", "5h", "Ad"});
TestEncode(new string[] {"8c", "Ks", "Td"});
TestEncode(new string[] {"Qh", "Ad", "5h"});

static int[] Encode(string[] cards) 
{
    const int NUMBER_OF_CARDS = 13;

    int[] result = new int[cards.Length];
    
    for(int index = 0; index < cards.Length; index++)
        // Ac = [0] A | [1] c
        result[index] = GetCardNumber(cards[index][0]) + (NUMBER_OF_CARDS * GetSuitNumber(cards[index][1]));

    Array.Sort(result);

    return result;
}
  
static string[] Decode(int[] cards) 
{
    string[] result = new string[cards.Length];

    return result;
}

static int GetSuitNumber(char suit)
{
    if(suit == 'c') return 0;
    if(suit == 'd') return 1;
    if(suit == 'h') return 2;
    return 3; // default s
}
static int GetCardNumber(char card)
{
    if(card == 'A') return 0;
    if(card == 'T') return 9;
    if(card == 'J') return 10;
    if(card == 'Q') return 11;
    if(card == 'K') return 12;

    return Convert.ToInt32(card.ToString()) - 1; // default 2 to 9 
}

static void TestEncode(string[] cards)
{
    int[] cardsEncode = Encode(cards);

    for(int ind = 0; ind < cardsEncode.Length; ind++)
        Console.Write($"{cardsEncode[ind]} | ");
    Console.WriteLine();
}