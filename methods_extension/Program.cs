using System;

namespace methods_extension
{
  class Program
  {
    static void Main(string[] args)
    {
      int result = 1;
      for (int i = 1; i < 5; i++)
        result = result * 3;
      Console.WriteLine(result);

      Operations instance = new();
      Console.WriteLine(instance.Expo(3, 4));

      // Extension Methods

      string expression = "Zeyneb Esra";
      bool result2 = expression.CheckSpaces();
      Console.WriteLine(result2);
      if (result2)
        Console.WriteLine(expression.RemoveWhiteSpaces());
      Console.WriteLine(expression.MakeUpperCase());
      Console.WriteLine(expression.MakeLowerCase());

      int[] array2 = { 9, 3, 6, 2, 1, 5, 0 };

      array2.SortArray();
      array2.PrintScreen();

      int number3 = 5;
      Console.WriteLine(number3.IsEvenNumber());

      Console.WriteLine(expression.GetFirstCharacter());
    }
  }

  public class Operations
  {

    public int Expo(int number, int base_)
    {
      if (base_ < 2)
      {
        return number;
      }
      return Expo(number, base_ - 1) * number;
    }

    // Expo(3,4)
    // Expo(3,3) * 3
    // Expo(3,2) * 3 * 3
    // Expo(3,1) * 3 * 3 * 3
  }

  public static class Extension
  {

    public static bool CheckSpaces(this string param)
    {
      return param.Contains(" ");
    }

    public static string RemoveWhiteSpaces(this string param)
    {
      string[] array = param.Split(" ");
      return string.Join("*", array);

    }

    public static string MakeUpperCase(this string param)
    {
      return param.ToUpper();
    }

    public static string MakeLowerCase(this string param)
    {
      return param.ToLower();
    }

    public static int[] SortArray(this int[] param)
    {

      Array.Sort(param);
      return param;
    }

    public static void PrintScreen(this int[] param)
    {

      foreach (int item in param)
      {
        Console.WriteLine(item);
      }
    }

    public static bool IsEvenNumber(this int param)
    {

      return param % 2 == 0;
    }

    public static string GetFirstCharacter(this string param)
    {

      return param.Substring(0, 1);
    }
  }
}
