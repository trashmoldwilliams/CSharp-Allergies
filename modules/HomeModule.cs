using Nancy;
using AllergyNS.Objects;
using System.Collections.Generic;

namespace ChangeModule
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        List<string> model = new List<string>() {};
        return View["index.cshtml", model];
      };

      Post["/"] = _ =>
      {
      List<string> inputList = Allergy.findAllergies(Request.Form["inputAllergyNum"]);
        return View["index.cshtml", inputList];
      };

    }
  }
}
