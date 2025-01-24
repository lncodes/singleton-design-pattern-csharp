namespace Lncodes.DesignPatterns.Singleton;

public sealed class BillPughSingleton
{
    private BillPughSingleton() { }

    private static class SingletonHelper
    {
        internal static readonly BillPughSingleton Instance = new();
    }

    public static BillPughSingleton GetInstance() =>
        SingletonHelper.Instance;
}