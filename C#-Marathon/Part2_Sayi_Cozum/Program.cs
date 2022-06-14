using System;

namespace Part2_Sayi_Cozum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                //giriş

                var input = "";
               
                const string exitCommand = "exit";

                input = inputSecreen();                

                if (input == exitCommand)
                {
                    Console.WriteLine("GÜLE GÜLE");
                    break;
                }

                charToIntLoop(input);

            } while (true);

        }
     
        static string inputSecreen()
        {
            var input = "";
            bool result;
            int number;
            const string exitCommand = "exit";

            do
            {
                Console.WriteLine("Bir Sayı Giriniz: ");

                input = Console.ReadLine();
                result = int.TryParse(input, out number);

                if (input == exitCommand)
                {
                    break;
                }
                if (!result)
                {
                    Console.WriteLine("Hatalı Giriş Yaptınız..!");
                }

            } while (!result);

            return input;
        }
        static void charToIntLoop(string input)
        {
            char[] num = input.ToCharArray();
            int Kat = 10;
            int TempKat = 1;
            int Cozum;
            string TempNum;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                TempNum = num[i].ToString();

                Cozum = (int.Parse(TempNum)) * TempKat;

                Console.WriteLine($"{num[i]}*{TempKat}={Cozum}");
                TempKat = TempKat * Kat;
            }
        }
    }
}
