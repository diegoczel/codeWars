//Console.WriteLine(isAValidMessage(""));

Console.WriteLine(isAValidMessage("3hey5hello2hi"));
Console.WriteLine(isAValidMessage("4code13hellocodewars"));
Console.WriteLine(isAValidMessage("3hey5hello2hi5"));
Console.WriteLine(isAValidMessage("code4hello5"));
Console.WriteLine(isAValidMessage("1a2bb3ccc4dddd5eeeee"));
Console.WriteLine(isAValidMessage(""));

Console.WriteLine();
Console.WriteLine(isAValidMessage("4codehello5"));
bool isAValidMessage(string message) 
{
    if(message.Length == 0)
        return true;

    if(!Char.IsDigit(message[0]) || Char.IsDigit(message[message.Length - 1]))
        return false;

    int i = 0;
    while(i < message.Length)
    {
        var c = QuantityOfNumberMode(i, ref message);

        // quantityOfNumber == 0 and i == last index of message, is ok value
        // quantityOfNumber == 0, fail validation
        if(c.quantityOfNumber == 0)
            return i == message.Length - 1;

        if(i + c.numberLength + c.quantityOfNumber <= message.Length)
        {
            if(message.Substring(i + c.numberLength, c.quantityOfNumber).Any(c => Char.IsDigit(c)))
            {
                return false;
            }
        }
        else
        {
            return false;
        }

        i += c.quantityOfNumber + c.numberLength;
    }

    return true;
}

(int quantityOfNumber, int numberLength) QuantityOfNumberMode(int startIndex, ref string msg)
{
    string numberStr = "";
    
    for(int i = startIndex; i < msg.Length; i++)
    {
        if(!Char.IsDigit(msg[i]))
        {
            break;
        }

        numberStr += msg[i].ToString();
    }

    if(numberStr.Length == 0)
        return (0, 0);
    return (Convert.ToInt32(numberStr), numberStr.Length);
}
