using Xunit;
using System;

namespace Lncodes.DesignPatterns.Singleton.Tests;

public abstract class SingletonTests
{
    protected static void AssertSingletonInstanceEqual<T>(Func<T> getInstance) where T : class
    {
        var expected = getInstance();
        var actual = getInstance();

        Assert.Same(expected, actual);
    }
}