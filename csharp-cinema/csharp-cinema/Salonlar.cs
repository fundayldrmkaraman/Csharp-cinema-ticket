using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_cinema
{
    // Salonlar sınıfı hangi filmin ne zaman nerde olduğu ile ilgili bilgileri tanımlar.
    class Salonlar
    {
        private string filmadı;
        private int saat;
        private DateTime tarih;
        private int salonnum;
        private List<Koltuklar> koltuk;

        public Salonlar(string filmadı, int saat, DateTime tarih, int salonnum)
        {
            this.filmadı = filmadı;
            this.saat = saat;
            this.tarih = tarih;
            this.salonnum = salonnum;
            koltuk = new List<Koltuklar> { };
        }
        public bool Dolu(int sıraNo, int koltukNo)
        {
            foreach (Koltuklar item in koltuk)
            {
                if (item.doluMu == false)
                {
                    return false;
                }
            }
            return true;
        }
        public void koltukekle(Koltuklar koltukk)
        {
            koltuk.Add(koltukk);
        }
        public override string ToString()
        {
            return "Film adı:" + filmadı + "\nSaat:" + saat + "\nSalon:" + salonnum + "\nTarih" + tarih;
        }




    }
}
