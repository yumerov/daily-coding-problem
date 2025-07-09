using System.Text;

namespace RunLengthEncoding;

public static class StringExtensions
{
    public static string RunLengthEncode(this string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return string.Empty;
        }

        var output = new StringBuilder();
        var currentChar = str[0];
        var count = 1;

        for (var i = 1; i < str.Length; i++)
        {
            if (str[i] == currentChar)
            {
                count++;
            }
            else
            {
                output.Append(count).Append(currentChar);
                currentChar = str[i];
                count = 1;
            }
        }

        output.Append(count).Append(currentChar);

        return output.ToString();
    }

    public static string RunLengthDecode(this string str)
    {
        var output = new StringBuilder();
        var count = 0;

        foreach (var c in str)
        {
            if (char.IsDigit(c))
            {
                count = count * 10 + (c - '0');
            }
            else
            {
                output.Append(new string(c, count));
                count = 0;
            }
        }

        return output.ToString();
    }
}