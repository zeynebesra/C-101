using System;

namespace array_methods
{
  class Program
  {
    static void Main(string[] args)
    {
      // Sort

      int[] numberArray = { 23, 12, 4, 86, 72, 3, 11, 17 };

      Console.WriteLine("------ Unordered Array ----");
      foreach (var number in numberArray)
        Console.WriteLine(number);

      Console.WriteLine("------- Ordered List ------");
      Array.Sort(numberArray);

      foreach (var number in numberArray)
        Console.WriteLine(number);

      // Clear

      Console.WriteLine("----- Array Clear -----");
      Array.Clear(numberArray, 2, 2);

      foreach (var number in numberArray)
        Console.WriteLine(number);

      // Reverse

      Console.WriteLine("----- Array Reverse -----");
      Array.Reverse(numberArray);

      foreach (var number in numberArray)
        Console.WriteLine(number);

      // IndexOf

      Console.WriteLine("------ Array IndexOf ------");
      Console.WriteLine(Array.IndexOf(numberArray, 23));

      // Resize

      Console.WriteLine("----- Array Resize -----");
      Array.Resize<int>(ref numberArray, 9);
      numberArray[8] = 99;

      foreach (var number in numberArray)
        Console.WriteLine(number);
    }
  }
}
