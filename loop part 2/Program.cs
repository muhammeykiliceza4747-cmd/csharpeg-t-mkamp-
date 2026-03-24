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

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 )
                if (i % 7 == 0 )
                        Console.WriteLine(i);
            }

            // ıkıncı bolum
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)

                    Console.Write("*");
                Console.WriteLine();
            }
            // ucuncu bolum
            int total;
            total = 0;
            for (int i = 1;i <= 50;i++)
                
            { if  (i % 2 == 1 ) 
                    { Console.WriteLine(i); }

           total= total+i;
               

            }
            Console.WriteLine("toplam: " + total);


           
            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine("kütük kac kilo:");
               
                if (i < 500 )
                    i = Console.Read();
                
               
                }
            Console.WriteLine("kütük ayıklandı");
            

































































            #endregion


            Console.Read();





        }
    }
}
