using System;

namespace if_else_ternary
{
  class Program
  {
    static void Main(string[] args)
    {
      int time = DateTime.Now.Hour;

      if (time >= 6 && time < 11)
      {
        Console.WriteLine("Good Morning");
      }
      else if (time <= 18)
      {
        Console.WriteLine("Good Afternoon");
      }
      else
      {
        Console.WriteLine("Good Night");
      }

      string result = time <= 18 ? "Good Afternoon" : "Good Night";

      Console.WriteLine(result);
    }
  }
}
