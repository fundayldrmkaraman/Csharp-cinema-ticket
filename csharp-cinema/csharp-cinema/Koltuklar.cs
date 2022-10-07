using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_cinema
{
    // Koltuklar sınıfında koltukların durumunu belirleyerek  koltukların dolu mu boş mu olduğunu belirler ve yer ayırma metoduyla yer ayrılır.Sadece bu sınıfta kullanacağımız bilgilere
    // private her yerden erişmek isteiğimiz bilgilere public gibi access modifiers kullandık.
    class Koltuklar
    {
        private int sıra;
        private int koltuk;
        private bool dolu;
        public int sıraNo { get; }
        public int koltukNo { get; }
        public bool doluMu { get; }

        public Koltuklar(int sıro, int koltuk, bool dolu)
        {
            this.sıra = sıraNo;
            this.koltuk = koltukNo;
            this.dolu = doluMu;
        }
        public bool Ayir()
        {
            if (dolu == true)
            {
                this.dolu = true;
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
