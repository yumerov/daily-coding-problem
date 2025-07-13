namespace BalancedBrackets;

public static class StringExtensions
{
    public static bool AreBracketsBalanced(this string str)
    {
        if (str.Length == 0)
        {
            return true;
        }

        return false;
    }
}