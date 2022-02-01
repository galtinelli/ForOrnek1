using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForOrnek1
{
    class Program
    {
        //1 den 10 a kadar sayıları alt alta yazdıran program
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("Sayınız: "+i.ToString());
            }
            Console.ReadKey();
        }
    }
}
