using System.Collections.Generic;
using System;
using System.Linq;

namespace AllergyNS.Objects
{
  public class Allergy
  {

    // private double _totalAmount;
    // private List<int> = new List<int>(){};
    //
    // public double getAmount ()
    // {
    //   return _totalAmount;
    // }

    public Allergy()
    {

    }

    public static List<string> findAllergies(double input)
    {
      List<string> newList = new List<string>() {};
      if (input > 255)
      {
        input = 255;
      }

      if(input >= 128)
      {
        newList.Add("Cats");
        input -= 128;
      }

      if(input >= 64)
      {
        newList.Add("Pollen");
        input -= 64;
      }

      if(input >= 32)
      {
        newList.Add("Chocolate");
        input -= 32;
      }

      if(input >= 16)
      {
        newList.Add("Tomatoes");
        input -= 16;
      }

      if(input >= 8)
      {
        newList.Add("Strawberries");
        input -= 8;
      }

      if(input >= 4)
      {
        newList.Add("Shellfish");
        input -= 4;
      }

      if(input >= 2)
      {
        newList.Add("Peanuts");
        input -= 2;
      }

      if(input >= 1)
      {
        newList.Add("Eggs");
        input -= 1;
      }

      return newList;
    }

    // public getDollars ()
    // {
    //   return _dollar;
    // }
    //
    // public getQuarters ()
    // {
    //   return _quarter;
    // }
    //
    // public getDimes ()
    // {
    //   return _dime;
    // }
    //
    // public getNickels ()
    // {
    //   return _nickel;
    // }
    //
    // public getPennies ()
    // {
    //   return _penny;
    // }

  } // end class
} // end namespace
