using Nancy;
using PingPong.Objects;
using System.Collections.Generic;

namespace PingPong
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/submit"] = _ => {
        PingPongGame userInputGame = new PingPongGame();
        int userInt = Request.Form["userMax"];
        List<string> PingPongSequence = userInputGame.ListResults(userInt);
        return View["index.cshtml", PingPongSequence];
      };
    }
  }
}
