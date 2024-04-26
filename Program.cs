using System;

namespace acunmedya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sor Numarasını Giriniz:!");
            int qNum = Convert.ToInt32(Console.ReadLine());



            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i + ". Araç için Günü Girin");
                string dayInfo = Console.ReadLine();

                if (dayInfo == "CUMARTESİ" || dayInfo == "PAZAR")
                {
                    Console.WriteLine("OTOPARK KAPALI");
                    continue;
                }

                Console.WriteLine(i + ". Araç için iç dış yıkama istiyor musunuz ?");
                string carWash = Console.ReadLine();

                Console.WriteLine(i + ".Araç için otopark süresini girin");
                int time = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(i + ".Araç için araç tipini girin");
                string vehicleType = Console.ReadLine();

                int price = 0;
                if (carWash == "evet" && time <= 3)

                {
                    Console.WriteLine("İlk 3 saatiniz ücretsiz.");
                    price = 350;
                }

                else if (carWash == "evet" && time > 3)
                {
                    price = (time - 3) * 20 + 350;
                }

                else if (time <= 3)
                {
                    price = 120;
                }

                else if (time < 24)
                {
                    price = (time - 3) * 20 + 120;
                }

                else if ((time >= 24))
                {
                    price = 400;
                }

                if (vehicleType == "TIR" || vehicleType == "OTOBÜS")
                {
                    price = price * 2;
                }
                else if (vehicleType == "ENGELLİ")
                {
                    price = 0;
                }
                Console.WriteLine("Ödenen Tutar:" + price);

            }
        }

    }
}

