namespace RunLengthEncoding.Tests;

using RunLengthEncoding;

public class RunLengthEncodeTests
{
    [Fact]
    public void empty_string()
    {
        Assert.Equal("", "".RunLengthEncode());
    }
    
    [Fact]
    public void non_empty_string()
    {
        Assert.Equal("4A3B2C1D2A", "AAAABBBCCDAA".RunLengthEncode());
    }
}