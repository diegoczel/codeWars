using System.Text;

Console.WriteLine(LetterToPosition('c'));
Console.WriteLine(LetterToPosition('o'));
Console.WriteLine(PositionToLetter(LetterToPosition('c'), LetterToPosition('o')));

Console.WriteLine(ProccessWord("codewars"));
Console.WriteLine(ProccessWord("abcd"));
Console.WriteLine(ProccessWord("z"));
Console.WriteLine(ProccessWord("youhavechosentotranslatethiskata"));
Console.WriteLine(ProccessWord("triangle"));
Console.WriteLine(ProccessWord("b"));


string ProccessWord(string word)
{
    if(word.Length == 1)
    {
        return word;
    }

    var result = new StringBuilder(); 
    for(int i = 0; i < word.Length - 1; i++)
    {
        result.Append(PositionToLetter(
            LetterToPosition(word[i]),
            LetterToPosition(word[i+1])
        ));
    }

    return ProccessWord(result.ToString());
}



string PositionToLetter(int positionOfA, int positionOfB)
{
    var totalOfAPlusB = positionOfA + positionOfB;
    int pos;
    if(totalOfAPlusB % 26 == 0)
    {
        pos = 26;
    }
    else if(totalOfAPlusB > 26)
    {
        pos = totalOfAPlusB % 26;
    }
    else
    {
        pos = totalOfAPlusB;
    }

    return Convert.ToChar(pos + 96).ToString();
}

int LetterToPosition(char c)
{
    return Convert.ToInt32(c) - 96;
}