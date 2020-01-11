using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavayoluSimulasyonu
{
    
    public abstract class Kisi
    {
        public Kimlik KimlikBilgisi { get; set; }
        public int Maaliyet{ get;protected set; }
        public int Adeti { get; set; }
        public double TcKimlikNo { get;private set; }

        public Kisi()
        {
            KimlikBilgisi = new Kimlik(TcKimlikNo);
        }
        public abstract int MaaliyetHesapla();
    }
}
