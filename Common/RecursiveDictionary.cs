namespace Common;

/// <summary>
/// Recursive dictionary used as a tree
/// </summary>
public class RecursiveDictionary<T> : Dictionary<T, RecursiveDictionary<T>?> where T : notnull
{
    public int LeafCount
    {
        get
        {
            var count = 0;
            foreach (var child in Values)
            {
                if (child == null || child.Count == 0)
                {
                    count++;
                    continue;
                }

                count += child.LeafCount;
            }

            return count;
        }
    }
}