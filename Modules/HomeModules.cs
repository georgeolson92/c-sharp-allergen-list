using Nancy;
using System.Collections.Generic;
using Allergies.Objects;

namespace Allergies {

  public class HomeModule : NancyModule {

    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/result"] = _ => {
        AllergenList newAllergenList = new AllergenList();
        List <string> result = newAllergenList.AllergenGenerator(Request.Form["user-input"]);
        return View["result.cshtml", result];
      };
    }

  }

}
