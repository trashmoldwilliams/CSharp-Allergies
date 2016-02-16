using Xunit;
using AllergyNS.Objects;
using System.Collections.Generic;
using System;

namespace AllergyNS
{
  public class AllergyTest
  {
    [Fact]
    public void FindAllergies_Input128_OutputCats()
    {
      List<string> testList = new List<string>() {"Cats"};
      Assert.Equal(testList, Allergy.findAllergies(128));
    }

    [Fact]
    public void FindAllergies_Input64_OutputPollen()
    {
      List<string> testList = new List<string>() {"Pollen"};
      Assert.Equal(testList, Allergy.findAllergies(64));
    }

    [Fact]
    public void FindAllergies_Input32_OutputChocolate()
    {
      List<string> testList = new List<string>() {"Chocolate"};
      Assert.Equal(testList, Allergy.findAllergies(32));
    }

    [Fact]
    public void FindAllergies_Input16_OutputTomatoes()
    {
      List<string> testList = new List<string>() {"Tomatoes"};
      Assert.Equal(testList, Allergy.findAllergies(16));
    }

    [Fact]
    public void FindAllergies_Input8_OutputStrawberries()
    {
      List<string> testList = new List<string>() {"Strawberries"};
      Assert.Equal(testList, Allergy.findAllergies(8));
    }

    [Fact]
    public void FindAllergies_Input4_OutputShellfish()
    {
      List<string> testList = new List<string>() {"Shellfish"};
      Assert.Equal(testList, Allergy.findAllergies(4));
    }

    [Fact]
    public void FindAllergies_Input2_OutputPeanuts()
    {
      List<string> testList = new List<string>() {"Peanuts"};
      Assert.Equal(testList, Allergy.findAllergies(2));
    }

    [Fact]
    public void FindAllergies_Input1_OutputEggs()
    {
      List<string> testList = new List<string>() {"Eggs"};
      Assert.Equal(testList, Allergy.findAllergies(1));
    }

    [Fact]
    public void FindAllergies_Input255_AllAllergies()
    {
      List<string> testList = new List<string>() {"Cats", "Pollen", "Chocolate", "Tomatoes", "Strawberries", "Shellfish", "Peanuts", "Eggs"};
      Assert.Equal(testList, Allergy.findAllergies(255));
    }

    [Fact]
    public void FindAllergies_Input1000_AllAllergies()
    {
      List<string> testList = new List<string>() {"Cats", "Pollen", "Chocolate", "Tomatoes", "Strawberries", "Shellfish", "Peanuts", "Eggs"};
      Assert.Equal(testList, Allergy.findAllergies(1000));
    }


    // [Fact]
    // public void Find_Exact_Change()
    // {
    //   Assert.Equal(2, Change.findDollars(.55));
    // }
  }
}
