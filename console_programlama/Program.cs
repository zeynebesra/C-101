// See https://aka.ms/new-console-template for more information


namespace console_programlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhabalar!");
            Console.WriteLine("Adınızı giriniz:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı giriniz:");
            string surname = Console.ReadLine();
            Console.WriteLine("Hoşgeldin  " + name +" "+surname);
        }
    }
}