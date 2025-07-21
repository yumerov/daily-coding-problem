namespace AlphabetMappedNumericStrings;

public static class AlphabetMappedNumericMapper
{
    public static int GetNumber(char c) => c - 'a' + 1;
    public static char GetLetter(int n) => (char)(n - 1 + 'a');
}