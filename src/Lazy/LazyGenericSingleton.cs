namespace Lncodes.DesignPatterns.Singleton;

public abstract class LazyGenericSingleton<T> where T : class, new()
{
    private static T _instance = null;

    protected LazyGenericSingleton() { }

    public static T GetInstance() =>
        _instance ??= new();
}
