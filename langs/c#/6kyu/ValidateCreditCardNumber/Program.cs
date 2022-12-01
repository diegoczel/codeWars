//Console.WriteLine(validate(""));

Console.WriteLine(validate("1714"));
Console.WriteLine(validate("891"));
Console.WriteLine(validate("12345"));

Console.WriteLine(validate("477 073 360"));
Console.WriteLine(validate("5422 0148 5514"));
Console.WriteLine(validate("8314 7046 0245"));
Console.WriteLine(validate("6654 6310 43044"));
Console.WriteLine(validate("0768 2757 5685 6340"));
Console.WriteLine(validate("7164 6207 74042"));
Console.WriteLine(validate("8383 7332 3570 8514"));
Console.WriteLine(validate("481 135"));
Console.WriteLine(validate("355 032 5363"));


bool validate(string n)
{
    n = n.Replace(" ", "");
    var sumOfDigits = 0;
    var parity = n.Length % 2;

    for(int i = 0; i < n.Length; i++)
    {
        var num = Convert.ToInt32(n[i].ToString());
        if(!(i % 2 == parity))
        {
            sumOfDigits += num;
        }
        else if(num > 4)
        {
            sumOfDigits += 2 * num - 9;
        }
        else
        {
            sumOfDigits += 2 * num;
        }
    }

    return sumOfDigits % 10 == 0;
}