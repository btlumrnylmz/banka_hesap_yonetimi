using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp12
{
    public class VadesizHesap : Hesap
    {
        public VadesizHesap(string hesapNo, string hesapSahibi, decimal bakiye) : base(hesapNo, hesapSahibi, bakiye)
        {
        }

        public override void BilgileriGoster()
        {
            Console.WriteLine($"Vadesiz Hesap: {HesapNo}, Hesap sahibi: {HesapSahibi}, Bakiye: {Bakiye:C}");
        }
        public override void ParaYatir(decimal miktar)
        {
            Bakiye += miktar;
            Console.WriteLine($"{miktar:C} hesaba yatırıldı. Yeni bakiye:{Bakiye:C}");
        }
        public override void ParaCek(decimal miktar)
        {
            if (miktar <= Bakiye)
            {
                Bakiye -= miktar;
                Console.WriteLine($"{miktar:C} hesaptan çekildi. Yeni bakiye:{Bakiye:C}");
            }
            else { Console.WriteLine("Yetersiz Bakiye"); }

        }
    }
}