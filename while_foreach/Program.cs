using System;

namespace while_foreach
{
  class Program
  {
    static void Main(string[] args)
    {
      //   // While 
      //   Console.Write("Enter a number");
      //   int number = int.Parse(Console.ReadLine());
      //   int counter = 1;
      //   int total = 0;
      //   while (counter <= number)
      //   {
      //     total += counter;
      //     counter++;
      //   }
      //   Console.WriteLine(total / number);

      //   // While 2

      //   char character = 'a';
      //   while(character < 'z'){
      //       Console.Write(character);
      //       character++;
      //   }

      // ForEach

      string[] cars = { "BMW", "Ford", "Nissan", "Toyota" };

      foreach (var car in cars)
      {
        Console.WriteLine(car);
      }
    }
  }
}
