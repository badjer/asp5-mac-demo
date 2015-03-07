using System;
using Xunit;
using Asp5MacDemo.Logic;

namespace Asp5MacDemo.Logic.Tests
{
  public class HelloTests
  {
    [Fact]
    public void IsWorld()
    {
      var res = Hello.World();
      Assert.Equal("Hello World", res);
    }
  }
}
