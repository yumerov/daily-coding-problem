namespace AlphabetMappedNumericStrings.Tests;

public class AlphabetMappedNumericDecoderTests
{
    [Theory]
    [InlineData("0", 0)]
    [InlineData("1", 1)]
    [InlineData("2", 1)]
    [InlineData("3", 1)]
    [InlineData("4", 1)]
    [InlineData("5", 1)]
    [InlineData("6", 1)]
    [InlineData("7", 1)]
    [InlineData("8", 1)]
    [InlineData("9", 1)]
    public void OneDigit(string str, int count)
    {
        Assert.Equal(count, AlphabetMappedNumericDecoder.GetCount(str));
    }
    
    [Theory]
    [InlineData("10", 1)]
    [InlineData("11", 3)]
    [InlineData("12", 3)]
    [InlineData("13", 3)]
    [InlineData("14", 3)]
    [InlineData("15", 3)]
    [InlineData("16", 3)]
    [InlineData("17", 3)]
    [InlineData("18", 3)]
    [InlineData("19", 3)]
    [InlineData("20", 1)]
    [InlineData("21", 3)]
    [InlineData("22", 3)]
    [InlineData("23", 3)]
    [InlineData("24", 3)]
    [InlineData("25", 3)]
    [InlineData("26", 3)]
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
    [InlineData("75", 2)]
    [InlineData("80", 1)]
    [InlineData("86", 2)]
    [InlineData("90", 1)]
    [InlineData("97", 2)]
    public void TwoDigits(string str, int count)
    {
        Assert.Equal(count, AlphabetMappedNumericDecoder.GetCount(str));
    }
}