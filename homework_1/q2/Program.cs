/* 
Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
*/

using System;
namespace q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers: ");
            int value1 = Convert.ToInt32(Console.ReadLine());
            int value2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter {0} positive number: ", value1);
            int[] values = new int[value1];

            for (int k = 0; k < value1; k++)
            {
            values[k] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("----------------");

            for (int l = 0; l < values.Length; l++)
            {
            if (values[l] >= value2)
            {
                if (values[l] == value2 || values[l] % value2 == 0)
                {
                Console.WriteLine(values[l]);
                }
            }
            }

            
        }
    }
}

