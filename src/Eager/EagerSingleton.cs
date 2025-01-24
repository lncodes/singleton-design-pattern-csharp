namespace Lncodes.DesignPatterns.Singleton;

public sealed class EagerSingleton
{
    private static readonly EagerSingleton _instance = new();

    private EagerSingleton() { }

    public static EagerSingleton GetInstance() =>
        _instance;
}