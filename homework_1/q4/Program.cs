
/* 
Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
 Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
*/

using System;
namespace q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence: ");
            string sentence = Console.ReadLine();

            char[] delimiters = new char[] { ' ', '\r', '\n' };
            int wordNumber = sentence.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;

            int letterNumber = sentence.Replace(" ", "").Length;

            Console.WriteLine("-------------");
            Console.WriteLine("Total word number: {0}", wordNumber);
            
            Console.WriteLine("Total letter number: {0}", letterNumber);
            Console.WriteLine("-------------");
            
        }
    }
}


