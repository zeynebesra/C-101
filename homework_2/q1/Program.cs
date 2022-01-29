/*
Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. 
(ArrayList sınıfını kullanara yazınız.)
Negatif ve numeric olmayan girişleri engelleyin.
Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
*/


using System;
using System.Collections;
using System.Collections.Generic;

namespace q1
{
  class Program
  {
    static void Main(string[] args)
    {
      ArrayList asalOlanSayilar = new ArrayList();
      ArrayList asalOlmayanSayilar = new ArrayList();

      for (int i = 0; i < 20; i++)
      {
        Console.WriteLine("Lütfen {0}. sayıyı giriniz: ", i + 1);
        var value = Console.ReadLine();
        int integerValue;
        if (!int.TryParse(value, out integerValue))
        {
          Console.WriteLine("\nNumeric Olmayan Veri Girdiniz!!!");
          i--;
        }
        else if (integerValue <= 0)
        {
          Console.WriteLine("\nPozitif Olmayan Veri Girdiniz!!!");
          i--;
        }
        else
        {
          for (int j = integerValue - 1; j >= 2; j--)
          {
            if (integerValue % j == 0)
            {
              asalOlmayanSayilar.Add(integerValue);
              break;
            }
          }
          if (asalOlmayanSayilar.Contains(integerValue) == false)
          {
            asalOlanSayilar.Add(integerValue);
          }
        }
      }

      asalOlanSayilar.Sort();
      asalOlanSayilar.Reverse();
      asalOlmayanSayilar.Sort();
      asalOlmayanSayilar.Reverse();

      int asalToplam = 0;
      int asalOlmayanToplam = 0;

      Console.WriteLine("\n----------Asal Olan Sayılar-------------");
      for (int k = 0; k < asalOlanSayilar.Count; k++)
      {
        Console.WriteLine(asalOlanSayilar[k]);
        asalToplam += Convert.ToInt32(asalOlanSayilar[k]);
      }

      Console.WriteLine("\n------------ Asal Olmayan Sayılar ---------------");
      for (int l = 0; l < asalOlmayanSayilar.Count; l++)
      {
        Console.WriteLine(asalOlmayanSayilar[l]);
        asalOlmayanToplam += Convert.ToInt32(asalOlmayanSayilar[l]);
      }

      Console.WriteLine("\nAsal Olan Elemanların Sayısı: {0}", asalOlanSayilar.Count);
      Console.WriteLine("Asal Olmayan Elemanların Sayısı: {0}", asalOlmayanSayilar.Count);

      Console.WriteLine("\nAsal Olan Elemanların Ortalaması: {0}", asalToplam / asalOlanSayilar.Count);
      Console.WriteLine("Asal Olmayan Elemanların Ortalaması: {0}", asalOlmayanToplam / asalOlmayanSayilar.Count);



    }



  }
}
