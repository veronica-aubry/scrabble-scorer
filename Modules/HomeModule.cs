using Nancy;
using Scrabbles;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Project
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>{
      Scrabble newScrabble = new Scrabble("");
      return View ["index.cshtml", newScrabble];
    };

      Post["/"] = _ => {
      Scrabble newScrabble = new Scrabble(Request.Form["word"]);
      return View["index.cshtml", newScrabble];
      };
    }
  }
}
