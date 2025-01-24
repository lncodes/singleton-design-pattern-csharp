namespace Lncodes.DesignPatterns.Singleton;

public sealed class LazySingleton
{
    private static LazySingleton _instance = null;

    private LazySingleton() { }

    public static LazySingleton GetInstance() =>
        _instance ??= new();
}