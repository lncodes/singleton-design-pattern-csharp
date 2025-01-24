using Xunit;

namespace Lncodes.DesignPatterns.Singleton.Tests;

public sealed class LazySingletonTests : SingletonTests
{
    [Fact]
    public void LazySingleton_GetInstance_MultipleCalls_ReturnsSameInstance() =>
        AssertSingletonInstanceEqual(LazySingleton.GetInstance);

    [Fact]
    public void LazyGenericSingleton_GetInstance_MultipleCalls_ReturnsSameInstance() =>
        AssertSingletonInstanceEqual(LazyGenericSingleton<LazySingletonTests>.GetInstance);

    [Fact]
    public void BillPughSingleton_GetInstance_MultipleCalls_ReturnsSameInstance() =>
        AssertSingletonInstanceEqual(BillPughSingleton.GetInstance);

    [Fact]
    public void LazyClassicThreadSafeSingleton_GetInstance_MultipleCalls_ReturnsSameInstance() =>
        AssertSingletonInstanceEqual(LazyClassicThreadSafeSingleton.GetInstance);

    [Fact]
    public void LazyModernThreadSafeSingleton_GetInstance_MultipleCalls_ReturnsSameInstance() =>
        AssertSingletonInstanceEqual(LazyModernThreadSafeSingleton.GetInstance);

    [Fact]
    public void LazyClassicThreadSafeGenericSingleton_GetInstance_MultipleCalls_ReturnsSameInstance() =>
        AssertSingletonInstanceEqual(LazyClassicThreadSafeGenericSingleton<LazySingletonTests>.GetInstance);

    [Fact]
    public void LazyModernThreadSafeGenericSingleton_GetInstance_MultipleCalls_ReturnsSameInstance() =>
        AssertSingletonInstanceEqual(LazyModernThreadSafeGenericSingleton<LazySingletonTests>.GetInstance);
}