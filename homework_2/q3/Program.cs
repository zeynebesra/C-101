/*
Soru - 3: 
Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan 
ve dizinin elemanlarını sıralayan programı yazınız.
*/

using System;
using System.Text.RegularExpressions;


namespace q3
{
  class Program
  {
    static void Main(string[] args)
    {

        Console.WriteLine("Bir cümle giriniz: ");
        string cumle = Console.ReadLine();

        cumle = cumle.Replace(" ", "");
        cumle = Regex.Replace(cumle, "[BCDFGHJKLMNPQRSTVXZbcdfghjklmnpqrstvxz]", "");

        char[] harfler = cumle.ToCharArray();

        foreach (var harf in harfler)
        {
            Console.Write(harf);
        }
    }
  }
}