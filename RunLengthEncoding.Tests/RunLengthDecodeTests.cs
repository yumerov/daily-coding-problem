namespace RunLengthEncoding.Tests;

using RunLengthEncoding;

public class RunLengthDecodeTests
{
    [Fact]
    public void empty_string()
    {
        Assert.Empty("".RunLengthDecode());
    }

    [Fact]
    public void non_empty_string()
    {
        Assert.Equal("AAAABBBCCDAA", "4A3B2C1D2A".RunLengthDecode());
    }
}