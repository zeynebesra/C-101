using System;

namespace methods
{
  class Program
  {
    static void Main(string[] args)
    {
      int a = 2;
      int b = 3;
      Console.WriteLine(a + b);

      int result = Add(a, b);
      Console.WriteLine(result);

      Methods sample = new Methods();
      sample.printScreen(Convert.ToString(result));

      int result2 = sample.IncreaseAndAdd(ref a, ref b);
      sample.printScreen(Convert.ToString(result2));
      sample.printScreen(Convert.ToString(a + b));

    }

    static int Add(int value1, int value2)
    {
      return (value1 + value2);
    }
  }

  class Methods
  {
    public void printScreen(string veri)
    {
      Console.WriteLine(veri);
    }

    public int IncreaseAndAdd(ref int value1, ref int value2)
    {
      value1++;
      value2++;
      return value1 + value2;
    }
  }
}
