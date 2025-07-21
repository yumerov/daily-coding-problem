namespace Common;

public class Memorizer<T, TR>
{
    private readonly Dictionary<int, TR> _cache = new();

    public Func<T, TR> Memorize(Func<T, TR> func)
    {
        return arg =>
        {
            var key = arg!.GetHashCode();
            if (_cache.TryGetValue(key, out var cached))
            {
                return cached;
            }
            
            _cache[key] = func(arg);
            return _cache[key];
        };
    }
}