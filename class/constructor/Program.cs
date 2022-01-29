using System;

namespace constructor
{
  class Program
  {
    static void Main(string[] args)
    {
      /* Söz dizimi
    class SınıfAdı
    {
        [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
        [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([Parametre Listesi])
        {
            Metot Komutları
        }
    } 

    Erişim Belirleyiciler
      * Public
      * Private
      * Internal
      * Protected

      */

      Console.WriteLine("-------------- Çalışan 1 ----------------");
      Calisan calisan1 = new Calisan("Eda", "Öztürk", 23456798, "İK");
      calisan1.CalisanBilgileri();

      Console.WriteLine("-------------  Çalışan 2  -----------------");
      Calisan calisan2 = new Calisan();
      calisan2.Ad = "Zeyneb";
      calisan2.Soyad = "Öztürk";
      calisan2.No = 28934784;
      calisan2.Departman = "IT";
      calisan2.CalisanBilgileri();

      Console.WriteLine("------------- Çalışan 3 --------------");
      Calisan calisan3 = new Calisan("Esra", "Öztürk");
      calisan3.CalisanBilgileri();

    }
  }

  class Calisan
  {
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public Calisan(string ad, string soyad, int no, string departman)
    {
      this.Ad = ad;
      this.Soyad = soyad;
      this.No = no;
      this.Departman = departman;
    }

    public Calisan() { }

    public Calisan(string ad, string soyad)
    {
      this.Ad = ad;
      this.Soyad = soyad;
    }
    public void CalisanBilgileri()
    {
      Console.WriteLine("Çalışanın Adı: {0}", Ad);
      Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
      Console.WriteLine("Çalışanın Numarası: {0}", No);
      Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
    }
  }
}
