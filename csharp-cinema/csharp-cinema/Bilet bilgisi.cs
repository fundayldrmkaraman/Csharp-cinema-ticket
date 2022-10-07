using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_cinema
{
    // Bilet bilgisi sınıfında ise sinemaya gelen kişinin bilgilerinin bilgilerinin güvenli bi şekilde tutarız. bu yüzden propertyleri kullandık.Bir özelliğin değeri okunmak istendiğinde 
    // get, özelliğe atama yapmak istendiğinde set yapılabilir. 
    abstract class biletbilgisi
    {
        public string kisiad;
        public string kisisoyad;
        public string telno;
        public double fiyat;
        public Koltuklar koltuklar;
        protected string kisiAd { get => kisiad; set => kisiad = value; }
        protected string kisiSoyad { get => kisisoyad; set => kisisoyad = value; }
        protected string telNo { get => telno; set => telno = value; }
        protected double Fiyat { get => fiyat; set => fiyat = value; }
        protected Koltuklar Koltuklar { get => koltuklar; set => koltuklar = value; }

        public override string ToString()
        {
            return "Bilet \n Kişi adı:" + kisiAd + "Kişi soyadı:" + kisiSoyad + "Sıra No:" + koltuklar.sıraNo + "Koltuk no:" + koltuklar.koltukNo + "Fiyat:" + fiyat;
        }
    }
}
