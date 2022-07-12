Console.WriteLine(CleanString("abc#d##c"));
Console.WriteLine(CleanString("abc#"));

static string CleanString(string s)
{
    if(s == "") return "";

    Stack<char> letters = new Stack<char>();

    for(int ind = 0; ind < s.Length; ind++)
    {
        if(s[ind] == '#')
        {
            char letter_temp;
            letters.TryPop(out letter_temp);
        } else
        {
            letters.Push(s[ind]);
        }
    }

    return String.Join("", letters.Reverse());
}
