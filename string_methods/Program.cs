using System;

namespace string_methods
{
  class Program
  {
    static void Main(string[] args)
    {
      string variable = "Dersimiz CSharp, Hosgeldiniz!";
      string variable2 = "CSharp";

      // Length
      Console.WriteLine("---Length---");
      Console.WriteLine(variable.Length);

      // ToUpper, ToLower
      Console.WriteLine("---ToUpper---");
      Console.WriteLine(variable.ToUpper());
      Console.WriteLine("---ToLower---");
      Console.WriteLine(variable.ToLower());

      // Concat
      Console.WriteLine("---Concat---");
      Console.WriteLine(string.Concat(variable, "Merhaba"));

      // Compare CompareTo
      Console.WriteLine("---Compare---");
      Console.WriteLine(variable.CompareTo(variable2)); // 0, 1, -1 
      Console.WriteLine(string.Compare(variable, variable2, true));
      Console.WriteLine(string.Compare(variable, variable2, false));

      // Contains
      Console.WriteLine("--Contains---");
      Console.WriteLine(variable.Contains(variable2));
      Console.WriteLine(variable.EndsWith("Hosgeldiniz"));
      Console.WriteLine(variable.StartsWith("Merhaba"));

      // IndexOf
      Console.WriteLine("--IndexOf---");
      Console.WriteLine(variable.IndexOf("CS"));
      Console.WriteLine(variable.IndexOf("Zey"));
      Console.WriteLine(variable.LastIndexOf("i"));

      // Insert
      Console.WriteLine("---Insert---");
      Console.WriteLine(variable.Insert(0, "Merhaba "));

      // PadLeft, PadRight
      Console.WriteLine(variable + variable2.PadLeft(30));
      Console.WriteLine(variable + variable2.PadLeft(30, '*'));
      Console.WriteLine(variable.PadRight(50) + variable2);
      Console.WriteLine(variable.PadRight(50, '-') + variable2);

      // Remove
      Console.WriteLine(variable.Remove(10));
      Console.WriteLine(variable.Remove(5, 3));
      Console.WriteLine(variable.Remove(0, 1));

      // Replace
      Console.WriteLine(variable.Replace("CSharp", "C#"));
      Console.WriteLine(variable.Replace(" ", "*"));

      // Split
      Console.WriteLine(variable.Split(" ")[1]);

      // Substring
      Console.WriteLine(variable.Substring(4));
      Console.WriteLine(variable.Substring(4, 6));







    }
  }
}
