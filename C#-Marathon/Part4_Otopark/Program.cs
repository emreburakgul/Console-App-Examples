using System;

namespace Part4_Otopark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Otomobil için 1’e basın");
            Console.WriteLine("2. Motosiklet için 2’ye basın");
            Console.WriteLine("3. Minibüs için 3’e basın");
            Console.WriteLine("4. Kamyon (ve diğer ticari araçlar) için 4’e basın\n\r");

            var input = "";
            bool result;
            double number;

            Console.Write("Bir Sayı Giriniz: ");
            do
            {
                input = Console.ReadLine();
                result = double.TryParse(input, out number);

                if (!result)
                {
                    Console.Write(": " );
                    
                }
                else if (number > 5 )
                {
                    Console.Write(": ");
                 
                }

            } while (!result || number > 5);

            double ParkTime;

            
            do
            {
                Console.Write("Araç Kaç Saat Durdu? : ");
                input = Console.ReadLine();
                result = double.TryParse(input, out ParkTime);

                if (!result)
                {
                    Console.Write("Lütfeen Geçerli Bir Saat Yazınız__!!");
                }
                
            } while (!result || number > 5);

            int TotalPrice=0;

            if (number==1)
            {
                if (ParkTime<=2)
                {
                    TotalPrice = 5;
                }
                else if (ParkTime <= 6)
                {
                    TotalPrice = 10;
                } 
                else if (ParkTime <= 12)
                {
                    TotalPrice = 20;
                } 
                else if (ParkTime <= 24)
                {
                    TotalPrice = 35;
                }
                else
                {
                    int Kat;
                    Kat =((int)ParkTime) / 24;
                    TotalPrice = Kat * 20;
                }
            }
            if (number==2)
            {
                if (ParkTime <= 2)
                {
                    TotalPrice = 3;
                }
                else if (ParkTime <= 6)
                {
                    TotalPrice = 6;
                }
                else if (ParkTime <= 12)
                {
                    TotalPrice = 12;
                }
                else if (ParkTime <= 24)
                {
                    TotalPrice = 20;
                }
                else
                {
                    int Kat;
                    Kat = ((int)ParkTime) / 24;
                    TotalPrice = Kat * 10;
                }
            }
            if (number==3)
            {
                if (ParkTime <= 2)
                {
                    TotalPrice = 8;
                }
                else if (ParkTime <= 6)
                {
                    TotalPrice = 16;
                }
                else if (ParkTime <= 12)
                {
                    TotalPrice = 32;
                }
                else if (ParkTime <= 24)
                {
                    TotalPrice = 45;
                }
                else
                {
                    int Kat;
                    Kat = ((int)ParkTime) / 24;
                    TotalPrice = Kat * 25;
                }
            } 
            if (number==4)
            {
                if (ParkTime <= 2)
                {
                    TotalPrice = 15;
                }
                else if (ParkTime <= 6)
                {
                    TotalPrice = 30;
                }
                else if (ParkTime <= 12)
                {
                    TotalPrice = 60;
                }
                else if (ParkTime <= 24)
                {
                    TotalPrice = 100;
                }
                else
                {
                    int Kat;
                    Kat = ((int)ParkTime) / 24;
                    TotalPrice = Kat * 55;
                }
            }

            Console.WriteLine($"Ödememiz gereken tutar: {TotalPrice} TL");
        }
     
    
    }

}
