using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavayoluSimulasyonu
{
    
    public class Yolcu : Kisi
    {
        public int YolcuSayisi { get; set; }
        public int YolcuMaaliyet { get; set; }
        public Yolcu()
        {
            YolcuMaaliyet = 50;
        }
        public override int MaaliyetHesapla()
        {
            Maaliyet = Adeti * YolcuMaaliyet;
            return Maaliyet;
                
        }
    }
}
