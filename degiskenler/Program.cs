namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 1;
           sbyte b =2;

           short c = 3;
           ushort d = 4;

           Int16 e = 5;
           int f =6;
           Int32 g =7;
           Int64 h =8;

           uint i =9;
           long j =10;
           ulong k =11;

           float l =12;
           double m =13;
           decimal n =14;

          
           string p ="ab";
            
        
           bool r = true;
           bool s =false;

           DateTime dt = DateTime.Now;

           object o1 = "16";
           object o2 = "ab";
           object o3 = 17;
           object o4 = 18;
           object o5 = 18.1;


           string str1 = string.Empty;
           str1 = "Zeyneb Öztürk";
           string ad = "Zeyneb";
           string soyad = "Öztürk";
           string tamIsim = ad + " " +soyad

           //boolean
           bool bl = 3>5;

           //değişken dönüştürme
           string vb = "20";
           int ty =20;
           string nr = vb + ty.ToString();
           int er = ty + Convert.ToInt32(vb);
           int yu = ty + int.Parse(vb);

           //datetime
           string datetime = DateTime.Now.ToString("dd.MM.yyyy");
           Console.WriteLine(datetime);




        }
    }
}
