int[] testes = {1, 4, 9, 14, 19, 44, 49, 99, 444, 999, 3444, 3999};

foreach(var number in testes)
{
    Console.WriteLine($"{number} - {DecodeRomanV1(number)}");
}

static string DecodeRomanV2(int number)
{
    string romano = "";

    return romano;
}

static string DecodeRomanV1(int number)
{
    string romano = "";
    int[] valoresDecimais = new int[7];
    int[] valoresRomanosDecimais = {1000, 500, 100, 50, 10, 5, 1};
    char[] valoresRomanos = {'M', 'D', 'C', 'L', 'X', 'V', 'I'};

    for(int ind = 0; ind < valoresRomanosDecimais.Length; ind++)
    {
        valoresDecimais[ind] = number / valoresRomanosDecimais[ind];
        number = number % valoresRomanosDecimais[ind];
    }

    for(int ind = 0; ind < valoresDecimais.Length; ind++)
    {
        if(ind < valoresDecimais.Length - 1 && valoresDecimais[ind + 1] == 4)
        {
            if(valoresDecimais[ind] == 0)
            {
                romano += Convert.ToString(valoresRomanos[ind + 1]) + Convert.ToString(valoresRomanos[ind]);
            } else
            {
                romano += Convert.ToString(valoresRomanos[ind + 1]) + Convert.ToString(valoresRomanos[ind - 1]);
            }
            
        } else if (valoresDecimais[ind] > 0 && valoresDecimais[ind] < 4) 
        {

            romano += Repeat(valoresDecimais[ind], Convert.ToString(valoresRomanos[ind]));
        }
    }
    return romano;
}

static string Repeat(int quantity, string str)
{
    string r = "";
    for(int i = 0; i < quantity; i++)
    {
        r += str;
    }
    return r;
}