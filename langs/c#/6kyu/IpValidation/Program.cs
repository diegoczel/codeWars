using System.Text.RegularExpressions;

string[] testes = {"1.2.3.4", "123.45.67.89",
"1.2.3",
"1.2.3.4.5",
"123.456.78.90",
"123.045.067.089"
};

foreach(var test in testes)
{
    Console.WriteLine($"{test} - {is_valid_IP(test)}");
}

static bool is_valid_IP(string ipAddres)
{
    string ipPattern = @"^[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}$";
    
    if(!Regex.Match(ipAddres, ipPattern).Success) return false;

    string[] ipParts = ipAddres.Split(".");
    foreach(var ipPart in ipParts)
    {
        if((ipPart.Length > 1 && ipPart.StartsWith("0")) || Convert.ToInt32(ipPart) > 255) 
        {
            return false;
        }
    }

    return true;
}