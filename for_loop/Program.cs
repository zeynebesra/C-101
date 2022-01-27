using System;

namespace for_loop
{
  class Program
  {
    static void Main(string[] args)
    {


      // Example 1

      Console.Write("Enter a number: ");
      int number = int.Parse(Console.ReadLine());

      for (int i = 1; i <= number; i++)
      {
        if (i % 2 == 1)
          Console.WriteLine(i);
      }


      // Example 2

      int oddTotal = 0;
      int evenTotal = 0;
      for (int i = 1; i <= 1000; i++)
      {
        if (i % 2 == 1)
        {
          oddTotal += i;
        }
        else
          evenTotal += i;
      }

      Console.WriteLine("Odd Total: " + oddTotal);
      Console.WriteLine("Even Total: " + evenTotal);


      // Break Continue

      for (int i = 1; i < 10; i++)
      {
        if (i == 4)
          break;
        Console.WriteLine(i);
      }

      for (int i = 1; i < 10; i++)
      {
        if (i == 4)
          continue;
        Console.WriteLine(i);
      }
    }
  }
}