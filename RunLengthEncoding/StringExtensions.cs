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
        char currentChar = str[0];
        int count = 1;

        for (int i = 1; i < str.Length; i++)
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

        // Append the last sequence
        output.Append(count).Append(currentChar);

        return output.ToString();
    }
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