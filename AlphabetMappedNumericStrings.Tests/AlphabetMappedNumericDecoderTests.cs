namespace AlphabetMappedNumericStrings.Tests;

public class AlphabetMappedNumericDecoderTests
{
    [Theory]
    [InlineData("1", 1)]
    [InlineData("2", 1)]
    [InlineData("3", 1)]
    [InlineData("4", 1)]
    [InlineData("5", 1)]
    [InlineData("6", 1)]
    [InlineData("7", 1)]
    [InlineData("8", 1)]
    [InlineData("9", 1)]
    public void OneDigit(string str, int count) => AssertCount(count, str);

    [Theory]
    [InlineData("10", 1)]
    [InlineData("11", 2)]
    [InlineData("12", 2)]
    [InlineData("13", 2)]
    [InlineData("14", 2)]
    [InlineData("15", 2)]
    [InlineData("16", 2)]
    [InlineData("17", 2)]
    [InlineData("18", 2)]
    [InlineData("19", 2)]
    [InlineData("20", 1)]
    [InlineData("21", 2)]
    [InlineData("22", 2)]
    [InlineData("23", 2)]
    [InlineData("24", 2)]
    [InlineData("25", 2)]
    [InlineData("26", 2)]
    [InlineData("27", 2)]
    [InlineData("28", 2)]
    [InlineData("29", 2)]
    [InlineData("30", 1)]
    [InlineData("31", 2)]
    [InlineData("40", 1)]
    [InlineData("42", 2)]
    [InlineData("50", 1)]
    [InlineData("53", 2)]
    [InlineData("60", 1)]
    [InlineData("64", 2)]
    [InlineData("70", 1)]
    [InlineData("71", 2)]
    [InlineData("75", 2)]
    [InlineData("80", 1)]
    [InlineData("86", 2)]
    [InlineData("90", 1)]
    [InlineData("97", 2)]
    public void TwoDigits(string str, int count) => AssertCount(count, str);
    
    [Theory]
    [InlineData("101", 1)]
    [InlineData("111", 3)]
    [InlineData("271", 1)]
    public void ThreeDigits(string str, int count) => AssertCount(count, str);
    
    private static void AssertCount(int count, string str) =>
        Assert.Equal(count, new AlphabetMappedNumericDecoder(str).BuildTree().CombinationCount);
}