namespace Lncodes.DesignPatterns.Singleton;

public sealed class LazyClassicThreadSafeSingleton
{
    private static volatile LazyClassicThreadSafeSingleton _instance = null;

    private static readonly object _instanceLock = new();

    private LazyClassicThreadSafeSingleton() { }

    public static LazyClassicThreadSafeSingleton GetInstance()
    {
        if (_instance is null)
            lock (_instanceLock)
                if (_instance is null)
                    _instance = new();
        return _instance;
    }
}