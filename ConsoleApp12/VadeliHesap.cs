using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp12
{
    public class VadeliHesap : Hesap, IMevduat
    {
        public VadeliHesap(string hesapNo, string hesapSahibi, decimal bakiye, decimal faizOrani) : base(hesapNo, hesapSahibi, bakiye)
        {
          
            FaizOrani = faizOrani;
        }

        public decimal FaizOrani { get; set; }
        

        public override void BilgileriGoster()
        {
            Console.WriteLine($"Vadeli Hesap: {HesapNo}, Hesap sahibi: {HesapSahibi}" +
              $", Bakiye: {Bakiye:C}, Faiz oranı:{FaizOrani:P}");
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
        public void FaizHesaplama()
        {
            decimal faiz = Bakiye * FaizOrani;
            Bakiye += faiz;
            Console.WriteLine($"Faiz Hesaplandı: {faiz:C}. Yeni Bakiye: {Bakiye:C}");
        }

    }
}