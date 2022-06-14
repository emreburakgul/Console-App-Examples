using System;

namespace Part6_SifreGizleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kad, sifre;
            Console.WriteLine("Kullanıcı Adınız");
            kad = Console.ReadLine();
            Console.WriteLine("Şifreniz");
            sifre = sifeliyaz();
            Console.WriteLine("\nAdınız....={0} Şifreniz...={1}", kad, sifre);
            Console.ReadKey();
        }
        private static string sifeliyaz()
        {
            string pass = "";
            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    pass += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
                    {
                        pass = pass.Substring(0, (pass.Length - 1));
                        Console.Write("\b \b");
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            } while (true);
            return pass;
        }
    }
}