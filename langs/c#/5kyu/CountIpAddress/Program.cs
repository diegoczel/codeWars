// See https://aka.ms/new-console-template for more information
/*Console.WriteLine(Convert.ToString(2, 2));
Console.WriteLine(Convert.ToString(255 + 2, 2));
Console.WriteLine(Convert.ToInt64("1011111111", 2));
Console.WriteLine(Convert.ToInt32("100000001", 2));*/
Console.WriteLine(Convert.ToInt32("101000110010", 2));
Console.WriteLine(Convert.ToInt32("1010000", 2));
// 1010000 -> 80
// 101000110010
Console.WriteLine(IpsBetween("", ""));
Console.WriteLine(IpsBetween("10.0.0.0", "10.0.0.50")); // 50
Console.WriteLine(IpsBetween("10.0.0.0", "10.0.1.0")); // 256
Console.WriteLine(IpsBetween("20.0.0.10", "20.0.1.0")); // 246

static long IpsBetween(string start, string end)   
{
    if(start == "" || end == "") return 0;

    return Convert.ToInt64(IpToBin(end), 2) - Convert.ToInt64(IpToBin(start), 2);
}

static string IpToBin(string ip)
{
    string[] ips = ip.Split(".");
    ip = "";
    foreach(string i in ips)
        ip += Convert.ToString(Convert.ToInt32(i), 2).PadLeft(8, '0');
    return ip;
}