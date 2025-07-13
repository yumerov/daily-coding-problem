namespace BalancedBrackets;

public static class StringExtensions
{
    public static bool AreBracketsBalanced(this string str)
    {
        if (str.Length == 0)
        {
            return true;
        }
        
        var brackets = new Stack<char>();
        foreach (var c in str.Where(c => c.IsBracket()))
        {
            if (c.IsOpenBracket())
            {
                brackets.Push(c);
                continue;
            }

            if (brackets.Count == 0 || brackets.Pop() != c.GetOpenBracket())
            {
                return false;
            }
        }

        return brackets.Count == 0;
    }
}