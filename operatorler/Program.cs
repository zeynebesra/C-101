using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama ve işlemeli atama
            
           int a = 2;
           int b = 4;
           a = a+1;
           Console.WriteLine(a);
           a+=1;
           Console.WriteLine(a);
           a/=1;
           Console.WriteLine(a);
           b*=4;
           Console.WriteLine(b);

         // Mantıksal Operatorler

           bool isSuccess = true;
           bool isCompelted = false;

           if (isSuccess && isCompelted )
           Console.WriteLine("Perfect!");

           if (isSuccess || isCompelted )
           Console.WriteLine("Fine!");

           if (isSuccess && !isCompelted )
           Console.WriteLine("Great!");


         //İlişkisel Operator

           int c =1;
           int d =6;
           bool sonuc = c<d;           
           Console.WriteLine(sonuc);
           sonuc = d<c;
           Console.WriteLine(sonuc);
           sonuc = d==c;
           Console.WriteLine(sonuc);
           sonuc = d>=c;
           Console.WriteLine(sonuc);
           sonuc = d<=c;

        //Aritmatik operator

           int e =11;
           int f =34;
           int sonuc1 = e + f;
           Console.WriteLine(sonuc1);
           sonuc1 = e + f;
           Console.WriteLine(sonuc1);
           sonuc1 = e * f;
           Console.WriteLine(sonuc1);
           sonuc1 = e / f;
           Console.WriteLine(sonuc1);
           sonuc1 = f++;
           Console.WriteLine(sonuc1);

        //  % mod alma

           int z = 20%3;
           Console.WriteLine(Z);

        }
    }
    
}