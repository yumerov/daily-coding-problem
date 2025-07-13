namespace BalancedBrackets;

public static class CharExtensions
{
    public static char? GetOpenBracket(this char c) => c switch
    {
        ')' => '(',
        '}' => '{',
        ']' => '[',
        _ => null
    };

    public static bool IsOpenBracket(this char c) => c is '(' or '{' or '[';
    private static bool IsClosedBracket(this char c) => c is ')' or '}' or ']';
    public static bool IsBracket(this char c) => c.IsOpenBracket() || c.IsClosedBracket();
}