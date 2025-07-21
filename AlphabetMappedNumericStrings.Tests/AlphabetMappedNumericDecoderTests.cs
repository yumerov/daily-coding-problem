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
    [InlineData("27", 1)]
    [InlineData("28", 1)]
    [InlineData("29", 1)]
    [InlineData("31", 1)]
    [InlineData("42", 1)]
    [InlineData("53", 1)]
    [InlineData("64", 1)]
    [InlineData("71", 1)]
    [InlineData("75", 1)]
    [InlineData("86", 1)]
    [InlineData("97", 1)]
    public void TwoDigits(string str, int count) => AssertCount(count, str);
    
    [Theory]
    [InlineData("101", 1)]
    [InlineData("111", 3)]
    [InlineData("271", 1)]
    public void ThreeDigits(string str, int count) => AssertCount(count, str);
    
    [Theory]
    [InlineData("3333333333", 1)]
    [InlineData("1111111111", 89)]
    public void TenDigits(string str, int count) => AssertCount(count, str);
    
    [Theory]
    [InlineData("33333333333333333333", 1)]
    [InlineData("11111111111111111111", 10946)]
    public void TwentyDigits(string str, int count) => AssertCount(count, str);
    
    [Theory]
    [InlineData("33333333333333333333333333333333333", 1)]
    [InlineData("11111111111111111111111111111111111", 14_930_352)]
    public void Performance_NoMemorization(string str, int count) => AssertCount(count, str);
    
    [Theory]
    [InlineData("33333333333333333333333333333333333", 1)]
    [InlineData("11111111111111111111111111111111111", 14_930_352)]
    public void Performance_Memorization(string str, int count) => Assert.Equal(
        count,
        new AlphabetMappedNumericDecoder(str, true).BuildTree().CombinationCount);
    
    private static void AssertCount(int count, string str) =>
        Assert.Equal(count, new AlphabetMappedNumericDecoder(str).BuildTree().CombinationCount);
}