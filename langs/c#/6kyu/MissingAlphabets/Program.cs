using System.Text;

Console.WriteLine(MissingAlphabets("abcab"));

string MissingAlphabets(string s)
{
    var dict = MakeDictOfAlphabetic();
    var maxQuantityOfLetter = 0;
    var missingLetters = new StringBuilder();

    for(int i = 0; i < s.Length; i++)
    {
        if(dict.ContainsKey(s[i]))
        {
            dict[s[i]] += 1;
            if(dict[s[i]] > maxQuantityOfLetter)
            {
                maxQuantityOfLetter = dict[s[i]];
            }
        }
    }

    foreach(var x in dict.Keys)
    {
        if(dict[x] < maxQuantityOfLetter)
        {
            missingLetters.Append(RepeatChar(x, maxQuantityOfLetter - dict[x]));
        }
    }
    
    return missingLetters.ToString();
}

Dictionary<char, int> MakeDictOfAlphabetic()
{
    var dict = new Dictionary<char, int>();
    for(int i = 97; i < 123; i++)
    {
        dict.Add(Convert.ToChar(i), 0);
    }

    return dict;
}

string RepeatChar(char c, int len)
{
    var builder = new StringBuilder();
    for(int i = 0; i < len; i++)
    {
        builder.Append(c.ToString());
    }

    return builder.ToString();
}