using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HavayoluSimulasyonu
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ucus ucus = new Ucus();
            ucus.KalkisYeri = "İzmir";
            ucus.VarisYeri = "Ankara";
            ucus.UcusKodu = "PP45";
            
            Pilot pilot = new Pilot();
            pilot.Adeti= 1;
            pilot.MaaliyetHesapla();

            KabinMemuru kabinMemuru = new KabinMemuru();
            kabinMemuru.Adeti = 1;
            kabinMemuru.MaaliyetHesapla();

            Yolcu yolcu = new Yolcu();
            yolcu.Adeti = 1;
            yolcu.MaaliyetHesapla();

            ucus.UcanEkle(pilot);
            ucus.UcanEkle(kabinMemuru);
            ucus.UcanEkle(yolcu);

            ucus.MaaliyetHesapla();

            MessageBox.Show(ucus.UcusKodu + "No lu Uçağın ...\n" +
                            "Uçus Kalkış Yeri :" + ucus.KalkisYeri +
                            "\nUçuş Varış Yeri :" + ucus.VarisYeri +
                            "\nUçakta :\n"+pilot.Adeti+"Adet Pilot\n"+
                            kabinMemuru.Adeti+ "Adet Kabin Memuru\n" +
                            yolcu.Adeti+"Adet Yolcu Bulunmaktadır..."+

                            "\nUçuş Toplam Maaliyeti : " + ucus.UcusMaaliyeti);

            MessageBox.Show("BİZİ TERCİH ETTİĞİNİZ İÇİN TEŞEKKÜR EDERİZ...");

           
          
        }
    }
}
