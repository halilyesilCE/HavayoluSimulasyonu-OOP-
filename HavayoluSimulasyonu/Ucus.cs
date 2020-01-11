using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavayoluSimulasyonu
{
 
    public class Ucus
    {
        public string UcusKodu{ get; set; }
        public string KalkisYeri{ get; set; }
        public string VarisYeri { get; set; }
        public int UcusMaaliyeti { get; set; }
        public List<Kisi> Ucanlar { get; set; }
        public Ucus()
        {
            Ucanlar = new List<Kisi>();
        }
        public void UcanEkle(Kisi kisi)
        {
            Ucanlar.Add(kisi);
        }
        public int MaaliyetHesapla()
        {
            UcusMaaliyeti = 0;
            foreach (Kisi kisi in Ucanlar)
            {
                UcusMaaliyeti += kisi.Maaliyet;
            }

            return UcusMaaliyeti;
        }

    }

}
