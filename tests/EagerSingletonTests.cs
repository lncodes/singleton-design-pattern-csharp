using Xunit;

namespace Lncodes.DesignPatterns.Singleton.Tests;

public sealed class EagerSingletonTests : SingletonTests
{
    [Fact]
    public void EagerSingleton_GetInstance_MultipleCalls_ReturnsSameInstance() =>
        AssertSingletonInstanceEqual(EagerSingleton.GetInstance);

    [Fact]
    public void EagerGenericSingleton_GetInstance_MultipleCalls_ReturnsSameInstance() =>
        AssertSingletonInstanceEqual(EagerGenericSingleton<EagerSingletonTests>.GetInstance);
}