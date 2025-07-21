using Common;

namespace AlphabetMappedNumericStrings;

using RecursiveIntDictionary = RecursiveDictionary<int>;

public class AlphabetMappedNumericDecoder
{
    private readonly string _value;
    public int CombinationCount => _tree.LeafCount;
    private RecursiveIntDictionary _tree = new();
    private readonly Memorizer<string, RecursiveIntDictionary>? _memorizer;

    public AlphabetMappedNumericDecoder(string value, bool cached = false)
    {
        _value = value;
        if (cached)
        {
            _memorizer = new Memorizer<string, RecursiveIntDictionary>();
        }
    }

    public AlphabetMappedNumericDecoder BuildTree()
    {
        _tree = BuildTree(_value);

        return this;
    }
    
    private RecursiveIntDictionary BuildTree(string currenValue)
    {
        return _memorizer == null ? _BuildTree(currenValue) : _memorizer.Memorize(_BuildTree)(currenValue);
    }
    
    private RecursiveIntDictionary _BuildTree(string currenValue)
    {
        if (currenValue.Equals("0") || currenValue.Equals(""))
        {
            return new RecursiveIntDictionary();
        }

        if (currenValue.Length == 1)
        {
            return new RecursiveIntDictionary
            {
                [int.Parse(currenValue)] = null
            };
        }

        var head = int.Parse(currenValue[..2]);
        var tail = currenValue[2..];

        return head switch
        {
            10 => new RecursiveIntDictionary { [head] = null },
            20 => new RecursiveIntDictionary { [head] = BuildTree(tail) },
            >= 11 and <= 26 => new RecursiveIntDictionary
            {
                [head / 10] = BuildTree($"{head % 10}{tail}"), [head] = BuildTree(tail)
            },
            _ => new RecursiveIntDictionary { [head / 10] = BuildTree($"{head % 10}{tail}") }
        };
    }
}