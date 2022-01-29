/* 
Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
 Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
*/

using System;
namespace q3
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter {0} words : ", number);
            string[] words = new string[number];

            for (int i = 0; i < number; i++)
            {
            words[i] = Console.ReadLine();
            }

            Console.WriteLine("--------------");

            for (int j = words.Length; j >= 1; j--)
            {
            Console.WriteLine(words[j - 1]);
            }
        }
    }
}


