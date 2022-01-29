using System;

namespace enum
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(Gunler.Pazar);
      Console.WriteLine((int)Gunler.Cumartesi);

      int sıcaklık = 32;

      if (sıcaklık <= (int)HavaDurumu.Normal)
      {
        Console.WriteLine("Dışarıya çıkmak için havanın ısınması lazım");
      }
      else if (sıcaklık >= (int)HavaDurumu.CokSıcak)
      {
        Console.WriteLine("Hava dışarıya çıkmak için çok sıcak");
      }
      else if (sıcaklık >= (int)HavaDurumu.Normal && sıcaklık < (int)HavaDurumu.CokSıcak)
      {
        Console.WriteLine("Hadi dışarıya çıkalım");
      }
    }
  }

  enum Gunler
  {
    Pazartesi = 1,
    Salı,
    Carsamba,
    Persembe,
    Cuma = 23,
    Cumartesi,
    Pazar
  }

  enum HavaDurumu
  {
    Soguk = 5,
    Normal = 20,
    Sıcak = 25,
    CokSıcak = 30
  }
}
