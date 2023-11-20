using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AskOlcer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(" ....AŞK ÖLÇER PROGRAMINA HOŞGELDİNİZ ....");



            Console.ResetColor();


            Console.Write("Senin Adın: ");
            string isim1 = Console.ReadLine();

            Console.Write("Onun Adı: ");
            string isim2 = Console.ReadLine();




            int askyuzde = AskYuzdesi(isim1, isim2);

            Console.WriteLine("Aşk Yüzdesi: " + askyuzde);




            Console.ReadLine();
        }
        static int AskYuzdesi(string isimbir, string isimiki)
        {

            int toplam1 = 0;
            int toplam2 = 0;
            foreach (char harf in isimbir)
            {
                toplam1 += (int)harf;

            }
            foreach (char harf in isimiki)
            {
                toplam2 += (int)harf;

            }

            int askyuzde = (toplam1 + toplam2) % 101;
            return askyuzde;
        }


    }
}
