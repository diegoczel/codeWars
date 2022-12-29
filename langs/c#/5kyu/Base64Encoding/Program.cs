using System;
using System.Text;

/*
Console.WriteLine(ToBase64("this is a string!!"));
Console.WriteLine(ToBase64("ee")); // ZWU=
Console.WriteLine(ToBase64("eee")); // ZWVl
Console.WriteLine(ToBase64("eeee")); // ZWVlZQ==
Console.WriteLine(ToBase64("e")); // ZQ==
*/
Console.WriteLine(FromBase64("ZQ=="));

static string ToBase64(string s)
{
    if (s == "") return "";

    var builder = new StringBuilder();

    foreach (var x in s)
    {
        builder.Append(Convert.ToString(x, 2).PadLeft(8, '0'));
    }

    var result = new StringBuilder();
    var ss = (builder.ToString().ToString().Length % 6 == 0) ? builder.ToString().ToString() : builder.ToString().PadRight((builder.ToString().Length) + (6 - (builder.ToString().Length - (builder.ToString().Length / 6 * 6))), '0');
    for (int i = 0; i < ss.Length; i += 6)
    {
        var d = Convert.ToInt32(ss.Substring(i, 6), 2);
        if (d < 26)
        {
            result.Append(Convert.ToChar(65 + d));
        }
        else if (d < 52)
        {
            result.Append(Convert.ToChar(97 + d - 26));
        }
        else if (d < 62)
        {
            result.Append(Convert.ToChar(48 + d - 52));
        }
        else if (d == 63)
        {
            result.Append('+');
        }
        else
        {
            result.Append('/');
        }
    }

    return (result.ToString().Length % 4 == 0) ? result.ToString() : result.ToString().PadRight((result.ToString().Length / 4 + 1) * 4, '=');
}

static string FromBase64(string s)
{
    if (s == "") return "";

    var countOfEqualAtEnd = 0;

    if(s.EndsWith("==")) countOfEqualAtEnd = 2;
    else if(s.EndsWith("=")) countOfEqualAtEnd = 1;

    var r = new StringBuilder();
    for (int ind = 0; ind < s.Length - countOfEqualAtEnd; ind++)
    {
        var d = Convert.ToInt32(s[ind]);
        if (d < 44)
        {
            r.Append('+');
        }
        else if (d < 48)
        {
            r.Append('/');
        }
        else if (d < 58)
        {
            r.Append(Convert.ToString(Convert.ToChar(d - 48 + 52), 2).PadLeft(6, '0'));
        }
        else if (d < 91)
        {
            r.Append(Convert.ToString(Convert.ToChar(d - 65), 2).PadLeft(6, '0'));
        }
        else
        {
            r.Append(Convert.ToString(Convert.ToChar(d - 97 + 26), 2).PadLeft(6, '0'));
        }
    }

    var rr = r.ToString();
    var rrr = "";

    for (int i = 1; i <= r.ToString().Length / 8; i++)
    {
        rrr += Convert.ToChar(Convert.ToInt32(rr.Substring((i - 1) * 8, 8), 2));
    }

    return rrr;
}
