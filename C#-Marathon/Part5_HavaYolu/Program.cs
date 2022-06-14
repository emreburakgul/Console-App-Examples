using System;

namespace Part5_HavaYolu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ucak = new string[20];
            bool kontrol = false;
            int sınıf;

            do
            {
                Console.WriteLine("1. Business Class bölümü için 1 tuşuna basınız");
                Console.WriteLine("2. Economy Class bölümü için 2 tuşuna basınız");
                sınıf = int.Parse(Console.ReadLine());
                if (sınıf == 1 || 2 == sınıf)
                {
                    if (sınıf == 1)
                    {
                        BusinessClass(ucak);
                    }
                    else
                    {
                        EconomyClass(ucak);
                    }
                }
            } while (true);
        }
        static void BusinessClass(string[] ucak)
        {
            bool dogrukayıt = true;
            int koltuk;
            bool bosKoltuk = false;
            Console.WriteLine("Business Class boş koltuklar");
            for (int i = 0; i < 10; i++)
            {
                if (ucak[i] == null)
                {
                    Console.WriteLine($"- {i + 1}");
                    bosKoltuk = true;
                }
            }

            do
            {
                if (bosKoltuk)
                {
                    Console.WriteLine("Seçilen koltuk numarası: ");
                    if (int.TryParse(Console.ReadLine(), out koltuk))
                    {
                        if (koltuk <= 10 && 0 < koltuk)
                        {
                            if (ucak[koltuk - 1] == null)
                            {
                                kayıt(ucak, koltuk);
                                dogrukayıt = false;
                            }
                            else
                            {
                                Console.WriteLine($"{koltuk} Numaralı koltuk {ucak[koltuk - 1]} isimli yolcuya rezerve edilmiştir.");
                                Console.WriteLine("Lütfen boş koltuklardan birini seçiniz.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Yanlış kategorideki koltuğu seçtiniz. Lütfen tekrar Koltuk seçiniz.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("yanlış koltuk numarası girdiniz. Lütfen tekrar koltuk nuamrası yazınız. ");
                    }
                }
                else
                {
                    Console.WriteLine("Seçtiğiniz Business Class bçlümünde boş koltuk kalmamıştır.");
                    Console.WriteLine("Economy Class bölümündeki boş koltukları görmek ister misiniz? E/H");
                    if (Console.ReadLine() == "E")
                    {
                        EconomyClass(ucak);
                    }
                    else
                    {
                        Console.WriteLine("Bir sonraki uçuş kayıtları 4 saat sonradır.");
                    }
                }
            } while (dogrukayıt);
        }
        static void EconomyClass(string[] ucak)
        {
            bool dogrukayıt = true;
            int koltuk;
            bool boskoltuk = false;
            Console.WriteLine("Economy Class boş koltuklar");
            for (int i = 10; i < 20; i++)
            {
                if (ucak[i] == null)
                {
                    Console.WriteLine($"- {i+1}");
                    boskoltuk = true;
                }
            }

            do
            {
                if (boskoltuk)
                {
                    Console.WriteLine("Seçilen koltuk numarası: ");
                    if (int.TryParse(Console.ReadLine(), out koltuk))
                    {
                        if (koltuk <= 20 && 10 < koltuk)
                        {
                            if (ucak[koltuk - 1] == null)
                            {
                                kayıt(ucak, koltuk);
                                dogrukayıt = false;
                            }
                            else
                            {
                                Console.WriteLine($"{koltuk} Numaralı koltuk {ucak[koltuk - 1]} isimli yolcuya rezerve edilmiştir.");
                                Console.WriteLine("Lütfen boş koltuklardan birini seçiniz.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Yanlış kategorideki koltuğu seçtiniz. Lütfen tekrar Koltuk seçiniz.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("yanlış koltuk numarası girdiniz. Lütfen tekrar koltuk nuamrası yazınız. ");
                    }
                }
                else
                {
                    Console.WriteLine("Seçtiğiniz Business Class bçlümünde boş koltuk kalmamıştır.");
                    Console.WriteLine("Buisness Class bölümündeki boş koltukları görmek ister misiniz? E/H");
                    if (Console.ReadLine() == "E")
                    {
                        BusinessClass(ucak);
                    }
                    else
                    {
                        Console.WriteLine("Bir sonraki uçuş kayıtları 4 saat sonradır.");
                    }
                }
            } while (dogrukayıt);
        }
        static void kayıt(string[] ucak, int koltuk)
        {
            Console.Write("Lütfen yolcunun adını soyadını giriniz: ");
            ucak[koltuk - 1] = Console.ReadLine();
        }
    }
}