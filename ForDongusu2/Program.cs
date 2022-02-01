using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForOrnek2
{
    class Program
    {
        //1 ile 40 arasındaki 40 dahil çift sayıların toplamını ekrana yazdıran program
        static void Main(string[] args)
        {
            float toplam = 0;
            for (int i = 1; i < 41; i++)
            {
                if (i % 2 == 0)
                {
                    toplam = toplam + i;
                    //toplam += i;
                }
            }

            //for (int i = 2; i <= 40; i+2)
            //       toplam += i;

            Console.WriteLine("1 ile 40 arasındaki 40 dahil çift sayıların toplamı: " + toplam);
            Console.ReadLine();
        }
    }
}
