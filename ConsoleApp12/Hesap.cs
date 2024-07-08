using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp12
{
    public abstract class Hesap
    {
        public string HesapNo { get; set; }
        public string HesapSahibi { get; set; }
        public decimal Bakiye { get; set; }
        public Hesap(string hesapNo, string hesapSahibi, decimal bakiye)
        {
            HesapNo = hesapNo;
            HesapSahibi = hesapSahibi;
            Bakiye = bakiye;
        }
        public abstract void BilgileriGoster();
        public abstract void ParaYatir(decimal miktar);
        public abstract void ParaCek(decimal miktar);
    }
}