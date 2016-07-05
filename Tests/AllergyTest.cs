using System.Collections.Generic;
using System;
using Xunit;
namespace Allergies.Objects
{
  public class AllergiesTest
  {
    [Fact]
    public void AllergenGenerator_userInputFour_ReturnList()
    {
      //Arrange
      List <string> expectedResult = new List <string> {"shellfish"};
      AllergenList newAllergenList = new AllergenList();

      //Act
      List <string> result = newAllergenList.AllergenGenerator(4);

      //Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void AllergenGenerator_userInputTwelve_ReturnList()
    {
      //Arrange
      List <string> expectedResult = new List <string> {"strawberries", "shellfish"};
      AllergenList newAllergenList = new AllergenList();

      //Act
      List <string> result = newAllergenList.AllergenGenerator(12);

      //Assert
      Assert.Equal(expectedResult, result);
    }

  }
}
