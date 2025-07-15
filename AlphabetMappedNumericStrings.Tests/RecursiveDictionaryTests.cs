namespace AlphabetMappedNumericStrings.Tests;

public class RecursiveDictionaryTests
{
    [Fact]
    public void root_only()
    {
        // Arrange
        var tree = new RecursiveDictionary<int>();

        // Act && Assert
        Assert.Equal(0, tree.LeafCount);
    }
    
    [Fact]
    public void direct_leaves()
    {
        // Arrange
        var tree = new RecursiveDictionary<int>
        {
            [1] = null,
            [2] = null,
            [3] = null,
        };

        // Act && Assert
        Assert.Equal(3, tree.LeafCount);
    }
    
    [Fact]
    public void indirect_leaves()
    {
        // Arrange
        var tree = new RecursiveDictionary<int>
        {
            [1] = new RecursiveDictionary<int>
            {
                [1] = null
            },
            [2] = null,
        };

        // Act && Assert
        Assert.Equal(2, tree.LeafCount);
    }
}