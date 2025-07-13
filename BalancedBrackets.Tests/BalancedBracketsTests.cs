
namespace BalancedBrackets.Tests;

public class BalancedBracketsTests
{
    [Fact]
    public void empty_string()
    {
        Assert.True("".AreBracketsBalanced());
    }
    
    [Fact]
    public void balanced_string()
    {
        Assert.True("([])".AreBracketsBalanced());
    }
    
    [Fact]
    public void unbalanced_string()
    {
        Assert.False("([)]".AreBracketsBalanced());
    }
    
    [Fact]
    public void mixed_string()
    {
        Assert.True("(a(b)c()d)".AreBracketsBalanced());
    }
}
