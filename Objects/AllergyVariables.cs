using System.Collections.Generic;
using System;

namespace Allergies.Objects
{
  public class AllergenList
  {
    public List<string> AllergenGenerator(int input)
    {
      List<string> results = new List<string> {};
      if (input >= 4)
      {
        results.Add("shellfish");
        input -= 4;
      }
      return results;
    }
  }

}
