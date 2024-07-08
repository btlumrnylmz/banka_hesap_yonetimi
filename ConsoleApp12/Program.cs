using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VadesizHesap vadesizHesap = new VadesizHesap("123456789", "Ali Veli", 10000m);
            vadesizHesap.BilgileriGoster();
            vadesizHesap.ParaYatir(5000m);
            vadesizHesap.ParaCek(1500m);
            Console.WriteLine("\n");

            VadeliHesap vadeliHesap = new VadeliHesap("112233445", "Ayşe Fatma", 20000m, 30m);
            vadeliHesap.BilgileriGoster();
            vadeliHesap.ParaYatir(400m);
            vadeliHesap.FaizHesaplama();
            vadeliHesap.ParaCek(30000m);
            Console.WriteLine("\n");

            KrediHesabi krediHesabi = new KrediHesabi("123412345", "Betül Ümran", 3000m, 40000m, 3000m);
            krediHesabi.BilgileriGoster();
            krediHesabi.ParaYatir(4000m);
            krediHesabi.KrediKullan(1500m);
            krediHesabi.KrediOdeme(2500m);
            Console.WriteLine("\n");

            List<Hesap> hesaplar = new List<Hesap> { vadesizHesap, vadeliHesap, krediHesabi };
            foreach (var hesapp in hesaplar)
            {
                hesapp.BilgileriGoster();
            }
            IMevduat mevduathesap = vadeliHesap;
            mevduathesap.FaizHesaplama();

            IKredi kredihesap = krediHesabi;
            kredihesap.KrediKullan(20000m);
            kredihesap.KrediOdeme(4000m);
        }
    }
}
