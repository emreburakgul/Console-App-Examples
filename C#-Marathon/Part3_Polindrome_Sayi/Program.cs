using System;

namespace Part3_Polindrome_Sayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                var input = "";
                bool result;
                int number;
                const string exitCommand = "exit";

                do
                {
                    Console.Write("Bir Sayı Giriniz: ");

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

                if (input == exitCommand)
                {
                    Console.WriteLine("GÜLE GÜLE");
                    break;
                }

                char[] num = input.ToCharArray();


                int[] Cozum = new int[input.Length];
                string TempNum;
                int LastIndex = input.Length - 1;
                bool TempResult, MainResult = true;
                // int[] TempCozum = new int[input.Length];

                for (int i = 0; i < input.Length; i++)
                {
                    TempNum = num[i].ToString();

                    Cozum[i] = int.Parse(TempNum);
                }

                for (int i = 0; i < input.Length / 2; i++)
                {
                    result = Cozum[LastIndex - i] == Cozum[i];

                    TempResult = result;
                    MainResult = MainResult && TempResult;
                }

                if (MainResult)
                {
                    Console.WriteLine($"{number}Polindrom sayıdır!!");
                }
                else
                {
                    Console.WriteLine($"{number}\tpolindrom sayı DEĞİLDİR!!!");
                } 

            } while (true);
        }
    }
}
