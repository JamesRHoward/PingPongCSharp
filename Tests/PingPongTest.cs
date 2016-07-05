using Xunit;
using PingPong.Objects;
using System.Collections.Generic;

namespace PingPong
{
  public class PingPongTest
  {
    [Fact]
    public void PingPong_ForNumber_SelfAsString()
    {
      PingPongGame testPingPong = new PingPongGame();
      Assert.Equal("1", testPingPong.IsPingPong(1));
    }
    [Fact]
    public void PingPong_ForNumberDivisibleByThree_ping()
    {
      PingPongGame testPingPong = new PingPongGame();
      Assert.Equal("ping", testPingPong.IsPingPong(3));
    }
    [Fact]
    public void PingPong_ForNumberDivisibleByFive_pong()
    {
      PingPongGame testPingPong = new PingPongGame();
      Assert.Equal("pong", testPingPong.IsPingPong(5));
    }
    [Fact]
    public void PingPong_ForNumberDivisibleByFifteen_pingpong()
    {
      PingPongGame testPingPong = new PingPongGame();
      Assert.Equal("pingpong", testPingPong.IsPingPong(30));
    }
    [Fact]
    public void PingPong_ForNumberSix_testOutput()
    {
      PingPongGame testPingPong = new PingPongGame();
      Assert.Equal(new List<string> { "1", "2", "ping", "4", "pong", "ping", "7" }, testPingPong.ListResults(7));
    }
  }
}
