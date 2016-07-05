using System.Collections.Generic;

namespace PingPong.Objects

{
  public class PingPongGame
  {
    public string IsPingPong(int number)
    {
      if (number % 15 == 0)
      {
        return "pingpong";
      }
      else if (number % 5 == 0)
      {
        return "pong";
      }
      else if (number % 3 == 0)
      {
        return "ping";
      }
      else
      {
        return number.ToString();
      }
    }

    public List<string> ListResults(int maxNumber)
    {
      List<string> PingPongSequence = new List<string> {};
      for ( var i = 1; i <= maxNumber; i++)
      {
        PingPongSequence.Add(this.IsPingPong(i));
      }
      return PingPongSequence;
    }

  }
}
