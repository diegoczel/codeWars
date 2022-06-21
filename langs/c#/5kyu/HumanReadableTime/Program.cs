Console.WriteLine("00:00:00" + " - " + GetReadableTime(0));
Console.WriteLine("00:00:05" + " - " + GetReadableTime(5));
Console.WriteLine("00:01:00" + " - " + GetReadableTime(60));
Console.WriteLine("23:59:59" + " - " + GetReadableTime(86399));
Console.WriteLine("99:59:59" + " - " + GetReadableTime(359999));

static string GetReadableTime(int seconds)
{
    if(seconds == 0) return "00:00:00";

    int hora = 0;
    int minuto = 0;
    int segundo = 0;
    
    minuto = (int)(seconds / 60);
    segundo = seconds % 60;
    hora = (int)(minuto / 60);
    minuto = minuto % 60;

    return $"{FormatNumber(hora)}:{FormatNumber(minuto)}:{FormatNumber(segundo)}";
}

static string FormatNumber(int num)
{
    if(num < 10) return "0" + num.ToString();

    return num.ToString();
}
