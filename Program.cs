using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aklımdaki_sayı
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int tut = r.Next(100);
            while (true)
            {
                Console.WriteLine("Tuttuğum Sayıyı Bulabilir misin?:");
                int gs = Convert.ToInt32(Console.ReadLine());
                if (gs > tut) Console.WriteLine("büyük sayı girdin.");
                else if (gs < tut) Console.WriteLine("küçük sayı girdin.");
                else
                {
                    Console.WriteLine("harikasın.BİNNGGGGOOOOOOOO"); break;
                }
            }
        }
    }
}
