using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp12
{
    public class KrediHesabi : Hesap, IKredi
    {
        public decimal KrediLimiti { get; set; }
        public Decimal Borc { get; set; }
        public KrediHesabi(string hesapNo, string hesapSahibi, decimal bakiye, decimal krediLimiti, decimal borc)
            : base(hesapNo, hesapSahibi, bakiye)
        {
            KrediLimiti = krediLimiti;
            Borc = borc;
        }

        public override void BilgileriGoster()
        {
            Console.WriteLine($"Kredi Hesabı: {HesapNo}, Hesap sahibi: {HesapSahibi}" +
                $", Bakiye: {Bakiye:C}, Kredi Limiti:{KrediLimiti:C}, Borç: {Borc:C}");
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

        public void KrediKullan(decimal miktar)
        {
            if (Borc + miktar <= KrediLimiti)
            {
                Borc += miktar;
                Console.WriteLine($"{miktar:C} KrediLimiti kullanıldı. Yeni Borç: {Borc:C}");
            }
            else
            {
                Console.WriteLine("Kredi limiti aşıldı!!!");
            }
        }

        public void KrediOdeme(decimal miktar)
        {
            if (miktar <= Borc)
            {
                Borc += miktar;
                Console.WriteLine($"{miktar:C} kredi ödendi. Yeni Borç: {Borc:C}");
            }
            else
            {
                Console.WriteLine("Ödenen miktar borçtan fazla olamaz!!!");
            }
        }
    }
}