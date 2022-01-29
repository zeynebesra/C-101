using System;

namespace class_beginning
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

      Console.WriteLine("------------------");
      Calisan calisan1 = new Calisan();
      calisan1.Ad = "Zeyneb";
      calisan1.Soyad = "Öztürk";
      calisan1.No = 23456798;
      calisan1.Departman = "İK";
      calisan1.CalisanBilgileri();

      Console.WriteLine("--------------------");

      Calisan calisan2 = new Calisan();
      calisan2.Ad = "Esra";
      calisan2.Soyad = "Öztürk";
      calisan2.No = 28934784;
      calisan2.Departman = "IT";
      calisan2.CalisanBilgileri();

    }
  }
  class Calisan
  {
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;
    public void CalisanBilgileri()
    {
      Console.WriteLine("Çalışanın Adı: {0}", Ad);
      Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
      Console.WriteLine("Çalışanın Numarası: {0}", No);
      Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
    }
  }
}
