using System.Text;

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

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.Append('(');
        foreach (var key in Keys)
        {
            var children = this[key];
            if (children == null || children.Count == 0)
            {
                builder.Append($"{key} => NULL");
            }
            else
            {
                builder.Append($"{key} => {children.ToString()}, ");
            }
        }
        builder.Append(')');
        
        return builder.ToString();
    }
}