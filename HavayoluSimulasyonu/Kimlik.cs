using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavayoluSimulasyonu
{
    
    public class Kimlik
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public double TcKimlikNo { get; private set; }
       
        public Kimlik(double TcKimlikNo)
        {
            this.TcKimlikNo = TcKimlikNo;
        }
    }
}
