using System;

namespace inheritance
{
  public class bitkiler : canlilar
  {
    protected void FotosentezYapmak()
    {
      Console.WriteLine("Bitkiler fotosentez yapar");
    }
  }

  public class TohumluBitkiler : bitkiler
  {
    public TohumluBitkiler()
    {
      base.FotosentezYapmak();
      base.Beslenme();
      base.Bosaltim();
      base.Solunum();
    }
    public void TohumluCogalma()
    {
      Console.WriteLine("Tohumlu bitkiler tohumla çoğalır.");
    }
  }

  public class TohumsuzBitkiler : bitkiler
  {
    public TohumsuzBitkiler()
    {
      base.FotosentezYapmak();
      base.Beslenme();
      base.Bosaltim();
      base.Solunum();
    }
    public void SporlaCogalma()
    {
      Console.WriteLine("Tohumsuz bitkiler sporla çoğalır.");
    }
  }
}