using System;

namespace Part1_Sayi_Tahmini
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// GİRİŞ
            //1 1-10
            //2 1-100
            //3 1-1000
            var zorluk =  readInput();

            //RANDOM BELİRLEME
            int ReNumRandom = selectRandom(zorluk);          

            // TAHMİN BELİRLEME 
            game(ReNumRandom, zorluk);
            

            
        }


        static void girisEkrani()
        {

            Console.WriteLine("Lütfen aşağıdaki zorluk seviyelerinden birisini seçiniz: ");
            Console.WriteLine("1. Kolay seviye için 1'i tuşlayın ");
            Console.WriteLine("2. Orta seviye için 2'i tuşlayın ");
            Console.WriteLine("3. Zor seviye için 3'i tuşlayın ");
        }
        static int readInput()
        {
            int zorluk;
            string input;
            bool result;

            do
            {
                girisEkrani();

                input = Console.ReadLine();
                result = int.TryParse(input, out zorluk);

                if (!result || zorluk>3 )
                {
                    Console.WriteLine("Hatalı Giriş Yaptınız..!\n\r");

                }


            } while (!result);

            return zorluk;
        }

        static int selectRandom(int zorluk)
        {

            Random random = new Random();

            int number = 0;

            if (zorluk == 1)
            {
                number = random.Next(0, 11);
            }
            else if (zorluk == 2)
            {
                number = random.Next(0, 101);
            }
            else if (zorluk == 3)
            {
                number = (int)random.Next(0, 1001);
            }
            return number;  

        }

        static void game(int ReNumRandom ,int zorluk )
        {            
            string input;
            bool result;
            var tahmin = 0;
            var KacTahmin = 0;
            int Sonuc = 0;

            do
            {
                do
                {
                    Console.Write("Tahmininizi Giriniz : ");
                    input = Console.ReadLine();
                    result = int.TryParse(input, out tahmin);

                    int TahminSonuc = tahmin - ReNumRandom;
                    Sonuc = Math.Abs(TahminSonuc);

                    if (!result)
                    {
                        Console.WriteLine("Hatalı Giriş Yaptınız..!");

                    }

                } while (!result);

                if (zorluk == 1)
                {
                    if (Sonuc <= 2 && Sonuc != 0)
                    {
                        Console.WriteLine("SICAK");
                    }
                    else if (Sonuc <= 4 && Sonuc != 0)
                    {
                        Console.WriteLine("ILIK");
                    }
                    else if (Sonuc <= 7 && Sonuc != 0)
                    {
                        Console.WriteLine("SOĞUK");
                    }

                }
                else if (zorluk == 2)
                {
                    if (Sonuc <= 20 && Sonuc != 0)
                    {
                        Console.WriteLine("SICAK");
                    }
                    else if (Sonuc <= 40 && Sonuc != 0)
                    {
                        Console.WriteLine("ILIK");
                    }
                    else if (Sonuc <= 100 && Sonuc != 0)
                    {
                        Console.WriteLine("SOĞUK");
                    }


                }
                else if (zorluk == 3)
                {
                    if (Sonuc <= 100 && Sonuc != 0)
                    {
                        Console.WriteLine("SICAK");
                    }
                    else if (Sonuc <= 300 && Sonuc != 0)
                    {
                        Console.WriteLine("ILIK");
                    }
                    else if (Sonuc <= 1000 && Sonuc != 0)
                    {
                        Console.WriteLine("SOĞUK");
                    }

                }

                if (Sonuc == 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }

                KacTahmin++;

            } while (!result);

            Console.WriteLine($"Tebrikler!! {tahmin} doğru tahmin!!");
            Console.WriteLine($"Oyunu {KacTahmin} tahminde bildiniz.");

        }
    }
}




