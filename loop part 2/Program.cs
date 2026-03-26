using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace loop_part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}



            //for (int i = 1; i <= 200; i++)
            //{
            //    if (i % 5 == 0)
            //        Console.WriteLine(i);
            //}





            // bırırncı bolum



            // ucuncu bolum
           // int total;
           // total = 0;
           // for (int i = 1;i <= 50;i++)
                
           // { if  (i % 2 == 1 ) 
           //         { Console.WriteLine(i); }

           //total= total+i;
               

           // }
           // Console.WriteLine("toplam: " + total);


           
           // for (int i = 1; i <= 7; i++)88
           // {
           //     Console.WriteLine("kütük kac kilo:");
               
           //     if (i < 500 )
           //         i = Console.Read();
                
               
           //     }
           // Console.WriteLine("kütük ayıklandı");

            int sayac;
            sayac = 0;
            for (int i = 0; i <= 7; i++)
            {
                Console.WriteLine("kıloyu gıt aw");
                double kg;
                kg = Convert.ToDouble(Console.ReadLine());

                
                
                
                if (kg > 500)


                {
                    sayac++;

                }
              
              

            }
            Console.WriteLine(sayac);




           







































































            #endregion


            Console.Read();





        }
    }
}
