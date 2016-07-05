using System.Collections.Generic;
using System;

namespace Allergies.Objects
{
  public class AllergenList
  {
    public List<string> AllergenGenerator(int input)
    {
      List<string> results = new List<string> {};
      if (input >= 128)
      {
        results.Add("cats");
        input -= 128;
      }
      if (input >= 64)
      {
        results.Add("pollen");
        input -= 64;
      }
      if (input >= 32)
      {
        results.Add("chocolate");
        input -= 32;
      }
      if (input >= 16)
      {
        results.Add("tomatoes");
        input -= 16;
      }
      if (input >= 8)
      {
        results.Add("strawberries");
        input -= 8;
      }
      if (input >= 4)
      {
        results.Add("shellfish");
        input -= 4;
      }
      if (input >= 2)
      {
        results.Add("peanuts");
        input -= 2;
      }
      if (input >= 1)
      {
        results.Add("eggs");
        input -= 1;
      }
      return results;
    }
  }

}
