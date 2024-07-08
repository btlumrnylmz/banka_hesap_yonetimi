using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp12
{
    public interface IKredi
    {
        void KrediKullan(decimal v);
        void KrediOdeme(decimal v);
    }
}