using System.Text;

namespace RunLengthEncoding;

public static class StringExtensions
{
    public static string RunLengthEncode(this string str)
    {
        var output = new StringBuilder();
        char? lastChar = null;
        var count = 0;

        for (var index = 0; index < str.Length; index++)
        {
            var c = str[index];
            if (lastChar == null)
            {
                lastChar = c;
                count = 0;
            }

            if (c != lastChar && lastChar != null)
            {
                output.Append($"{count}{lastChar}");
                lastChar = c;
                count = 0;
            }

            if (c == lastChar)
            {
                count++;
            }

            if (index == str.Length - 1)
            {
                output.Append($"{count}{lastChar}");
            }
        }

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