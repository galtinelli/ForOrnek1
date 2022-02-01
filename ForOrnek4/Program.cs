using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForOrnek4
{
    class Program
    {
        //Kullanıcının girdiği 50'şer adet A,B,C değeri Y=(A+B)/C işlemi hesaplanyor. Pozitif Ylerin ortalamasını 30dan büyük 50 den küçük Ylerin sayısı
        static void Main(string[] args)
        {
            int A, B, C;
            double Y = 0;
            double pyt = 0, ayt = 0;
            int pys = 0;
            int ays = 0;

            for (int i = 1; i < 3; i++)
            {
                Console.WriteLine("A sayısını giriniz: ");
                A = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("B sayısını giriniz: ");
                B = Convert.ToInt32(Console.ReadLine());

            cyeniden: Console.WriteLine("C sayısını giriniz: ");
                C = Convert.ToInt32(Console.ReadLine());

                if (C == 0)
                {
                    Console.WriteLine("C sayısını yeniden giriniz");
                    goto cyeniden;
                }

                Y = (A + B) / C;

                if (Y > 0)
                {
                    pys=pys + 1;
                    pyt = pyt + Y;
                    if (Y > 30 && Y < 50)
                    {
                        ays = ays + 1;
                        ayt = ayt + Y;
                    }
                }
            }
            Console.WriteLine("Pozitif Y toplamı: " + pyt);
            Console.WriteLine("Aradaki Y toplamı: " + ayt);
            Console.WriteLine("Pozitif Y sayısı: " + pys);
            Console.WriteLine("Aradaki Y sayısı: " + ays);
            Console.ReadLine();

        }
    }

}
