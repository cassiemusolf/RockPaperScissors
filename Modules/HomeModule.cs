using Nancy;
using System;
using System.Collections.Generic;
using RockPaperScissors.Objects;

namespace GameApp
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Post["/output"] = _ => {
        Game thisGame = new Game();
        string formOutput = Request.Form["user1-input"];
        Console.WriteLine(formOutput);
        string output = thisGame.Shoot(Request.Form["user1-input"], Request.Form["user2-input"]);
        return View["output.cshtml", output];

      };
    }
  }
}
