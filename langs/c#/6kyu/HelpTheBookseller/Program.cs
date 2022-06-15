string[] l = {
    //"ABART 20", "CDXEF 50", "BKWRK 25", "BTSQZ 89", "DRTYM 60"
    "ABAR 200", "CDXE 500", "BKWR 250", "BTSQ 890", "DRTY 600"
};

string[] m = {
    //"A", "B", "C", "W"
    "A", "B"
};

Console.WriteLine(stockSummary(l, m));

static string stockSummary(String[] lstOfArt, String[] lstOf1stLetter) 
{
    if(lstOfArt.Length == 0 || lstOf1stLetter.Length == 0) return "";
    
    var firstLetter = new Dictionary<string, int>();
    string result = "";

    foreach(var letter in lstOf1stLetter)
    {
        firstLetter.Add(letter, 0);
    }

    foreach(var book in lstOfArt)
    {
        string letter = book[0].ToString();
        if(firstLetter.ContainsKey(letter))
        {
            // "ABART 20"
            firstLetter[letter] += Convert.ToInt32(book.Split(" ")[1]);
        }
    }

    foreach(var letter in lstOf1stLetter)
    {
        //if(firstLetter[letter] > 0)
        result += $"({letter} : {firstLetter[letter]}) - ";
    }

    return result.Trim(new char[] {' ', '-'});
}
