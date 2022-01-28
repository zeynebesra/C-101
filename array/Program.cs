using System;

namespace array
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] colors = new string[5];
      string[] animals = { "Cat", "Dog", "Bird", "Monkey", };

      int[] array;
      array = new int[5];

      colors[0] = "Blue";
      array[3] = 10;

      Console.WriteLine(animals[1]);
      Console.WriteLine(array[3]);
      Console.WriteLine(colors[0]);

      Console.Write("Array Length?: ");
      int arrayLength = int.Parse(Console.ReadLine());
      int[] numberArray = new int[arrayLength];

      for (int i = 0; i < arrayLength; i++)
      {
        Console.Write("Enter {0}. number: ", i + 1);
        numberArray[i] = int.Parse(Console.ReadLine());
      }

      int total = 0;
      foreach (var number in numberArray)
        total += number;

      Console.WriteLine("Average: " + total / arrayLength);
    }
  }
}
