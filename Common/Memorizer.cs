namespace Common;

public class Memorizer<T, TR> where T : notnull
{
    private readonly Dictionary<T, TR> _cache = new();

    public Func<T, TR> Memorize(Func<T, TR> func)
    {
        return arg =>
        {
            if (_cache.TryGetValue(arg, out var cached))
            {
                return cached;
            }
            
            _cache[arg] = func(arg);

            return _cache[arg];
        };
    }
}