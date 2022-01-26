using System;

namespace tip_donusumleri
{
  class Program
  {
    static void Main(string[] args)
    {
      // Implicit Conversion

      byte a = 5;
      sbyte b = 30;
      short c = 10;

      int d = a + b + c;
      Console.WriteLine("d:" + d);

      long h = d;
      Console.WriteLine("h:" + h);

      float i = h;
      Console.WriteLine("i:" + i);

      string e = "Esra";
      char f = 'e';
      object g = e + f + d;
      Console.WriteLine("g:" + g);


      // Explicit Conversion

      int x = 4;
      byte y = (byte)x;
      Console.WriteLine("y:" + +y);

      int z = 100;
      byte t = (byte)z;
      Console.WriteLine("t:" + t);

      float w = 18.3f;
      byte v = (byte)w;
      Console.WriteLine("w:" + w);


      // ToString

      int xx = 6;
      string yy = xx.ToString();
      Console.WriteLine("yy:" + yy);

      string zz = 12.5f.ToString();
      Console.WriteLine("zz:" + zz);


      // System.Convert

      string s1 = "10", s2 = "20";
      int number1, number2;
      int total;

      number1 = Convert.ToInt32(s1);
      number2 = Convert.ToInt32(s2);

      total = number1 + number2;
      Console.WriteLine("Total:" + total);


      // Parse

      ParseMethod();

    }

    public static void ParseMethod()
    {

      string text1 = "10";
      string text2 = "10.25";
      int number1;
      double double1;

      number1 = Int32.Parse(text1);
      double1 = Double.Parse(text2);

      Console.WriteLine("number1 :" + number1);
      Console.WriteLine("double1 :" + double1);

    }
  }
}
