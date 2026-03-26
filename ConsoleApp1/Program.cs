using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("******* kutuk holu *******");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //int ayıklanan;
            //ayıklanan = 0;
            //for (int i = 0; i <= 5; i++)
            //{

            //    Console.Write(" kutuk agırlık giriniz: ");
            //    int kutuk;

            //    kutuk = int.Parse(Console.ReadLine());

            //    if (kutuk > 500)
            //    {

            //        Console.WriteLine(" kutuk agırlık uygundur.");
            //        Console.WriteLine();
            //        Console.WriteLine();
            //        Console.WriteLine();
            //    }
            //    if (kutuk < 500)
            //    {

            //        Console.WriteLine(" kutuk ayıklandı. ");
            //        Console.WriteLine();
            //        Console.WriteLine();
            //        Console.WriteLine();





            //    }
            //    if (kutuk < 500)
            //    {
            //        ayıklanan++;

            //    }


            //}
            //Console.WriteLine(ayıklanan + "ayıklandı");

            // Console.WriteLine("gecen kutuk agırluk lıstesı");
            // int toplamkilo = 0;
            //int ayıklandı = 0;

            // for (int i = 0; i <= 5; i++)
            // { 
            //     Console.WriteLine("kutuk agırlıgı gırırnız: ");
            //     int kutuk;

            //     kutuk = int.Parse(Console.ReadLine());
            //     if (kutuk > 500)
            //     {
            //         Console.WriteLine(" kutuk agırlık uygundur.");
            //     }

            //     else
            //     {
            //         Console.WriteLine(" kutuk ayıklandı. ");
            //     }
            //     if (kutuk > 500)
            //     {
            //         toplamkilo = toplamkilo + kutuk;
            //     }
            //     if (kutuk < 500)
            //     {     ayıklandı++; }




            // }

            // Console.WriteLine("ayıklandı: " + ayıklandı);

            // Console.WriteLine("gecen kutuklerin toplam agırlıgı: " + toplamkilo);int[

            // Console.WriteLine("kutuk agırlıgı hesaplama ");
            // int[] kutuk = new int[3];
            // for (int i = 0; i < kutuk.Length; i++)
            // {
            //     Console.WriteLine("kutuk agırlıgı gırınız: ");
            //     kutuk[i] = int.Parse(Console.ReadLine());
            // }


            //Console.WriteLine("1. kutuk agırlıgı: " +kutuk[0]);
            //     Console.WriteLine("2. kutuk agırlıgı: " + kutuk[1]);
            //     Console.WriteLine("3. kutuk agırlıgı : " + kutuk[2]);
            //     Console.WriteLine("3. kutuk agırlıgı : " + kutuk[2]);

            // Console.WriteLine("ayıklandı: " + ayıklandı);

            // Console.WriteLine("gecen kutuklerin toplam agırlıgı: " + toplamkilo);int[

            // Console.WriteLine("kutuk agırlıgı hesaplama ");
            // int[] kutuk = new int[3];
            // for (int i = 0; i < kutuk.Length; i++)
            // {
            //     Console.WriteLine("kutuk agırlıgı gırınız: ");
            //     kutuk[i] = int.Parse(Console.ReadLine());
            //     if (kutuk[i] > 500)
            //     {
            //         Console.WriteLine(i+1 + ". kutuk agırlık uygundur.");
            //     }
            //     else
            //     {
            //         Console.WriteLine(i+1 +". kutuk ayıklandı. ");
            //     }
            // }


            //Console.WriteLine("1. kutuk agırlıgı: " +kutuk[0]);
            //     Console.WriteLine("2. kutuk agırlıgı: " + kutuk[1]);
            //     Console.WriteLine("3. kutuk agırlıgı : " + kutuk[2]);
            // Console.WriteLine("arsıvden veri alma ");
            // for (int i = 0; i < 3; i++)
            // {
            //     Console.WriteLine(i+1 + ". kutuk agırlıgı: " + kutuk[i]);
            // }
            Console.WriteLine("mesaı saatlerı ayın elemanı ");
             int sayac;
            sayac = 0;
            string ayınelemanı;
            ayınelemanı =null;
            
            string[] isimler = new string[3];
            string cevap= "evet";

            while (cevap=="evet")
            {
                for (int i = 0; i < isimler.Length; i++)
                {
                    Console.WriteLine("isim gırınız: ");
                    isimler[i] = Console.ReadLine();
                    while (isimler[i] == "")
                    {
                        Console.WriteLine("hatalı veri girişi");
                        Console.WriteLine("isim gırınız: ");
                        isimler[i] = Console.ReadLine();
                    }


                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                for (int i = 0; i < isimler.Length; i++)
                {
                    Console.WriteLine(i + 1 + ". isim: " + isimler[i]);
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                int[] mesailer = new int[3];
                for (int i = 0; i < mesailer.Length; i++)
                {

                    Console.WriteLine("mesai saati gırınız: ");
                    mesailer[i] = int.Parse(Console.ReadLine());
                    while (mesailer[i] < 0)
                    {
                        Console.WriteLine("hatalı gırıs");
                        Console.WriteLine("mesai saati gırınız: ");
                        mesailer[i] = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                for (int i = 0; i < mesailer.Length; i++)

                {
                    Console.WriteLine(isimler[i] + " mesai saati: " + mesailer[i]);

                    if (mesailer[i] > sayac)
                    {

                        sayac = mesailer[i];
                        ayınelemanı = isimler[i];





                    }


                    Console.WriteLine(ayınelemanı + "  ayın elelmanı " + sayac);
                }
                Console.WriteLine("yeni giris yapmak ıster misisniz ?");
               cevap= Console.ReadLine().ToLower();
                Console.WriteLine("hayırlı işler");
            }
        

















        }
    }
}
