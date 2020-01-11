using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavayoluSimulasyonu
{
 
    public class KabinMemuru : Kisi
    {
        public int KabinMemurSayisi { get; set; }
        public int KabinMemurMaas { get; set; }
        public KabinMemuru()
        {
            KabinMemurMaas = 4000;
        }
        public override int MaaliyetHesapla()
        {
            Maaliyet = Adeti * KabinMemurMaas;
            return Maaliyet;
        }
    }
}
