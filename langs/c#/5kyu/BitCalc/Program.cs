
static int Calculate(string num1, string num2)
{
    if(num1 == "" && num2 == "") return 0;

    if(num1.Length < num2.Length)
    {
        num1 = num1.PadLeft(num2.Length, '0');
    }
    else
    {
        num2 = num2.PadLeft(num1.Length, '0');
    }

    var mod = '0';
    var result = 0;
    for(int i = num1.Length - 1; i > -1; i--)
    {
        if(mod == '0')
        {
            if(num1[i] == '1' && num2[i] == '1')
            {
                mod = '1';
            }
            else if(num1[i] == '1' || num2[i] == '1')
            {
                result += (int)Math.Pow(2, num1.Length - 1 - i);
                mod = '0';
            }
            else
            {
                mod = '0';
            }
        }
        else
        {
            if(num1[i] == '0' && num2[i] == '0')
            {
                result += (int)Math.Pow(2, num1.Length - 1 - i);
                mod = '0';
            }
            else if(num1[i] == '0' || num2[i] == '0')
            {
                mod = '1';
            }
            else
            {
                result += (int)Math.Pow(2, num1.Length - 1 - i);
                mod = '1';
            }
        }
    }

    if(mod == '1') result += (int)Math.Pow(2, num1.Length);
    
    return result;
}