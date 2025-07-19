namespace Common;

public class Memorizer
{
    private readonly Dictionary<int, object> _cache = new();


    public Func<T, R> Memorize<T, R>(Func<T, R> func)
    {
        return arg =>
        {
            var key = arg!.GetHashCode();
            if (_cache.TryGetValue(key, out var cached))
            {
                return (R)cached;
            }
            
            _cache[key] = func(arg);
            return (R)_cache[key];
        };
    }
}