using System;

namespace struct
{
  class Program
  {
    static void Main(string[] args)
    {
      Dikdortgen dikdortgen = new Dikdortgen(); // new keywordu olmadan tanımlanamaz
      dikdortgen.KisaKenar = 3;
      dikdortgen.UzunKenar = 4;

      Console.WriteLine("Class Alan Hesabı: {0}", dikdortgen.AlanHesapla()); // KisaKenar ve UzunKenar değerlerine değer atanmamış olsa bile AlanHesapla fonksiyonu çağrılabilir. Çünkü biz değer atamasak bile nesne oluşturulduğunda integer fieldlar default olarak 0 değerini alır.

      // Dikdortgen_Struct dikdortgen_struct = new Dikdortgen_Struct(); // new keywordu olmadan da tanımlanabilir. Alttaki ilk 3 satır gibi

      // Dikdortgen_Struct dikdortgen_Struct;
      // dikdortgen_Struct.KisaKenar = 3;
      // dikdortgen_Struct.UzunKenar = 4;

      // Aşağıdaki satır parametreli constructor kullanımını örneklemek için 
      Dikdortgen_Struct dikdortgen_Struct = new Dikdortgen_Struct(3, 4);

      Console.WriteLine("Struct Alan Hesabı: {0}", dikdortgen_Struct.AlanHesapla()); // KisaKenar ve UzunKenar değerlerine değer atanmamış olduğunda AlanHesapla fonksiyonu çağrılamaz. Bizim bir şekilde değer atamış olmamız gerekiyor.
    }
  }

  class Dikdortgen
  {
    public int KisaKenar;
    public int UzunKenar;

    public Dikdortgen()
    {
      KisaKenar = 3;
      UzunKenar = 4;
    }
    // Yukarıdaki gibi parametresiz constructor(Kurucu fonksiyon) tanımlanabilir.

    public long AlanHesapla()
    {
      return this.KisaKenar * this.UzunKenar;
    }
  }

  struct Dikdortgen_Struct
  {
    public int KisaKenar;
    public int UzunKenar;

    // public Dikdortgen_Struct()
    // {
    //     KisaKenar = 3;
    //     UzunKenar = 4;
    // } 
    // Yukarıdaki gibi parametresiz constructor(Kurucu fonksiyon) tanımlanamaz.

    public Dikdortgen_Struct(int kisaKenar, int uzunKenar)
    {
      KisaKenar = kisaKenar;
      UzunKenar = uzunKenar;
    }
    // Constructor yukarıdaki gibi parametreli tanımlanmalıdır.

    public long AlanHesapla()
    {
      return this.KisaKenar * this.UzunKenar;
    }
  }
}
