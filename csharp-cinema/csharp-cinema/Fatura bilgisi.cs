using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_cinema
{
    // Fatura bilgisi sınıfında ise temel sınıf içerisinde türetilmiş olan sınıf üyelerine erişmek amacıyla base kullandık. tüm özellik ve fonksiyonlarına erişim sağlar ve ve kullanılır.

    class Faturabilgisi : biletbilgisi
    {
        public Faturabilgisi(string kisiad, string kisisoyad, string telno, double fiyat, Koltuklar koltuklar)
        {
            base.kisiAd = kisiad;
            base.kisiSoyad = kisisoyad;
            base.telNo = telno;
            base.Fiyat = 30;
            base.Koltuklar = koltuklar;
        }
    }
}
