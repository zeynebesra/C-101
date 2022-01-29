using System;

namespace encapsulation
{
  class Program
  {
    static void Main(string[] args)
    {
      Ogrenci ogrenci = new Ogrenci();
      ogrenci.Isim = "Zeyneb";
      ogrenci.Soyisim = "Öztürk";
      ogrenci.OgrenciNo = 555;
      ogrenci.Sinif = 2;
      ogrenci.OgrenciBilgileriniGetir();

      ogrenci.SinifAtlat();
      ogrenci.OgrenciBilgileriniGetir();

      Ogrenci ogrenci1 = new Ogrenci("Esra", "Karaahmetoğlu", 444, 1);
      ogrenci1.SinifDusur();
      ogrenci1.SinifDusur();
      ogrenci1.OgrenciBilgileriniGetir();
    }
  }

  class Ogrenci
  {
    private string isim;
    private string soyisim;
    private int ogrenciNo;
    private int sinif;

    public string Isim
    {
      get { return isim; }
      set { isim = value; }
    }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
    public int Sinif
    {
      get => sinif;
      set
      {
        if (value < 1)
        {
          Console.WriteLine("Sınıf En Az 1 Olmalıdır");
          sinif = 1;
        }
        else
          sinif = value;
      }
    }

    public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
    {
      Isim = isim;
      Soyisim = soyisim;
      OgrenciNo = ogrenciNo;
      Sinif = sinif;
    }

    public Ogrenci() { }

    public void OgrenciBilgileriniGetir()
    {
      Console.WriteLine("------------ Öğrenci Bilgileri ------------");
      Console.WriteLine("Öğrenci İsmi     : {0}", this.Isim);
      Console.WriteLine("Öğrenci Soyismi  : {0}", this.Soyisim);
      Console.WriteLine("Öğrenci No       : {0}", this.OgrenciNo);
      Console.WriteLine("Öğrenci Sınıfı   : {0}", this.Sinif);
    }

    public void SinifAtlat()
    {
      this.Sinif++;
    }
    public void SinifDusur()
    {
      this.Sinif--;
    }
  }
}
