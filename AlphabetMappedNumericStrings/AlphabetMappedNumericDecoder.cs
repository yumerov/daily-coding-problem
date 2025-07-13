namespace AlphabetMappedNumericStrings;

public static class AlphabetMappedNumericDecoder
{
    public static int GetCount(string str)
    {
        if (str.Length == 1) return CountOneChar(str);

        if (str.Length == 2) return CountTwoChars(str);

        return 0;

        // var head = int.Parse(str[..2]);
        //
        // var tail = str[2..];
        //
        // if (head > 26)
        // {
        //     return GetCount(tail);
        // }
        //
        // return GetCount(tail) + GetCount($"{head % 10}{tail}");
    }

    private static int CountOneChar(string str) => str[0] == '0' ? 0 : 1;

    private static int CountTwoChars(string str) => int.Parse(str[..2]) switch
    {
        var n when n % 10 == 0 => 1,
        >= 11 and <= 19 => 3,
        20 => 1,
        >= 21 and <= 26 => 3,
        _ => 2
    };
}