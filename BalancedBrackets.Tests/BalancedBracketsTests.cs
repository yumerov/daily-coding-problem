
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
}
