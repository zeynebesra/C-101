/*
Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları 
ve ortalama toplamlarını console'a yazdıran programı yazınız. 
(Array sınıfını kullanarak yazınız.)
*/

using System;
using System.Collections;
using System.Collections.Generic;

namespace q2
{
  class Program
  {
    static void Main(string[] args)
    {

        int[] numbers = new int[20];
        int[] biggestThree = new int[3];
        int[] smallestThree = new int[3];

        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("{0}. sayıyı giriniz: ", i + 1);
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Array.Sort(numbers);
        int biggestTotal = 0;
        int smallestTotal = 0;

        for (int j = 0; j < 3; j++)
        {
            smallestThree[j] = numbers[j];
            smallestTotal += numbers[j];
        }

        int smallestAverage = smallestTotal / smallestThree.Length;
        int a = 0;

        for (int k = 19; k > 16; k--)
        {
            biggestThree[a] = numbers[k];
            biggestTotal += numbers[k];
            a++;
        }

        int biggestAverage = biggestTotal / biggestThree.Length;

        Console.WriteLine("\nEn büyük 3 sayının ortalaması: {0}", biggestAverage);
        Console.WriteLine("En küçük 3 sayının ortalaması: {0}", smallestAverage);
        Console.WriteLine("Ortalamaların toplamı: {0}", smallestAverage + biggestAverage);

    }
  }
}


      
 

