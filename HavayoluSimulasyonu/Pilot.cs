using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavayoluSimulasyonu
{

    public class Pilot : Kisi
    {
        public int PilotSayisi { get; set; }
        public int PilotMaas { get; set; }
        public Pilot()
        {
            PilotMaas = 30000;
        }

        public override int MaaliyetHesapla()
        {
            Maaliyet = Adeti * PilotMaas;
            return Maaliyet;
         }
    }
}
