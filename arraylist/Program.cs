using System;
using System.Collections;
using System.Collections.Generic;

namespace arraylist
{
  class Program
  {
    static void Main(string[] args)
    {
      // System.Collection namespace

      ArrayList liste = new ArrayList();
      // liste.Add("Ayşe");
      // liste.Add(2);
      // liste.Add(true);
      // liste.Add('A');

      // // İçerisindeki verilere erişme
      // Console.WriteLine(liste[1]);
      // foreach (var item in liste)
      // {
      //     Console.WriteLine(item);
      // }

      // AddRange
      Console.WriteLine("--------- Add Range ---------");
      // string[] renkler = {"Kırmızı", "Sarı", "Yeşil"};
      List<int> sayilar = new List<int>() { 1, 8, 3, 7, 9, 92, 5 };
      liste.Add(sayilar);
      // liste.Add(renkler);

      foreach (var item in liste)
      {
        Console.WriteLine(item);
      }

      // Sort
      Console.WriteLine("--------------Sort -------------");
      liste.Sort(); // Kullanlabilmesi için arraylistte sadece sayı olmalı

      foreach (var item in liste)
      {
        Console.WriteLine(item);
      }

      // Binary Search
      Console.WriteLine("-------------- Binary Search ------------");
      Console.WriteLine(liste.BinarySearch(9)); // Kullanılabilmesi için arraylistin sıralı olması lazım. Verilen değerin indisini döner

      // Reverse
      Console.WriteLine("----------- Reverse -------------");
      liste.Reverse();

      foreach (var item in liste)
      {
        Console.WriteLine(item);
      }

      // Liste temizleme
      Console.WriteLine("------------Clear ----------");
      liste.Clear();

      foreach (var item in liste)
      {
        Console.WriteLine(item);
      }

    }
  }
}
