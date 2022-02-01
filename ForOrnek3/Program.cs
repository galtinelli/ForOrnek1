using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForOrnek3
{
    class Program
    {
        //Kullanıcıdan öğrenilen 10 adet sayıdan en büyüğünü ve en küçüğünü bulup ekrana yazdıran program
        static void Main(string[] args)
        {
            int enBuyuk=0, enKucuk=0;

            for (int i = 1; i < 10; i++)
            {
                if (i < i + 1)
                    enKucuk = i;

                else if (i > i + 1)
                    enBuyuk = i;
            }

            Console.WriteLine("En küçük sayı: " + enKucuk);
            Console.WriteLine("En küçük sayı: " + enBuyuk);

            Console.ReadKey();

        }
    }
}
