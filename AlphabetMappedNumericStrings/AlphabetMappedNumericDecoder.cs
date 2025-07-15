namespace AlphabetMappedNumericStrings;

using RecursiveIntDictionary = RecursiveDictionary<int>;

public class AlphabetMappedNumericDecoder(string value)
{
    private readonly string _value = value;
    public int CombinationCount => _tree.LeafCount;
    private readonly RecursiveIntDictionary _tree = new();
    private readonly Dictionary<string, RecursiveIntDictionary> _cachedBranches = new();

    public AlphabetMappedNumericDecoder BuildTree()
    {
        if (_value.Equals("0"))
        {
            return this;
        }
        
        _tree[0] = BuildTree(_value);

        return this;
    }

    private RecursiveIntDictionary BuildTree(string value)
    {
        // if (_cachedBranches.TryGetValue(value, out var tree))
        // {
        //     return tree;
        // }

        if (value.Equals("0"))
        {
            return new RecursiveIntDictionary();
        }
        
        if (value.Length == 1)
        {
            return new RecursiveIntDictionary
            {
                [int.Parse(value)] = null
            };
        }


        // if (value.Length == 2) return CountTwoChars(str);

        var tail = value[2..];

        return _cachedBranches[value];
    }

    // public int GetCount()
    // {
    //     if (str.Length == 1) return CountOneChar(str);
    //
    //     if (str.Length == 2) return CountTwoChars(str);
    //     
    //     var head = str[..2];
    //     var tail = str[2..];
    //     var headCombinations = CountTwoChars(head);
    //     if (headCombinations == 1) return GetCount(tail);
    //     if (headCombinations == 2) return GetCount(tail) + GetCount($"{head[1]}{tail}");
    //     
    //     return GetCount($"{head[1]}{tail}");
    // }

    private static int CountOneChar(string str) => str[0] == '0' ? 0 : 1;

    private static int CountTwoChars(string str) => int.Parse(str[..2]) switch
    {
        < 9 => 1,
        var n when n % 10 == 0 => 1,
        >= 11 and <= 19 or >= 21 and <= 26 => 2,
        _ => 2
    };
}