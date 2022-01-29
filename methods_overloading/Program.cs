using System;

namespace methods_overloading
{
  class Program
  {
    static void Main(string[] args)
    {
      // out parameters
      string number = "999";

      bool result = int.TryParse(number, out int outNumber);
      if (result)
      {
        Console.WriteLine("Successful");
        Console.WriteLine(outNumber);
      }
      else
      {
        Console.WriteLine("Unsuccessful");
      }

      Methods instance = new Methods();
      instance.Add(4, 5, out int addingResult);
      Console.WriteLine(addingResult);

      // Method Overloading

      int number2 = 999;
      instance.printScreen(Convert.ToString(number2));
      instance.printScreen(number2);
      instance.printScreen("zey", "zey");

      // Method Sign

      // Method Name + Parameter Number + Parameter Type 

      // These 3 shouldn't be the same


    }
  }

  class Methods
  {
    public void Add(int a, int b, out int result)
    {
      result = a + b;
    }

    public void printScreen(string info)
    {
      Console.WriteLine(info);
    }
    public void printScreen(int info)
    {
      Console.WriteLine(info);
    }

    public void printScreen(string info1, string info2)
    {
      Console.WriteLine(info1 + info2);
    }
  }
}
