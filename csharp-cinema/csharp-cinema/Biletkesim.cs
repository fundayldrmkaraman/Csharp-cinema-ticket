using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_cinema
{
    class Biletkesim
    {  // Biletkesim sınıfı birden çok metoda sahip olmakla beraber ilk önce kullanıcıdan bilgi alma amaçlı olarak bilgi metodunu kullanır.
       //Daha sonra filmsec metodu ile birlikte hangi filmin seçilen olduğunu hangi saat hangi zaman olduğunu hesaplarız.birden fazla seçenek olduğundan dolayı switch kullanarak işlem yapılır
       // Ekranda önce filmseç metoduyla sinema bilgileri daha sonra bilgi metoduyla kişi bilgileri yazdırılır.
       // En sonda oluşturduğumuz anamenu metodu bizim ilk başta seçim yapabilmemiz için oluşturduğumuz metod.
        private void Bilgi()
        {
            string[] kisiad = new string[50];
            string[] kisisoyad = new string[50];
            string[] telno = new string[10];
            string[] Koltuk = new string[5];

            Console.WriteLine("Adınız:");
            string kisiadi = Console.ReadLine();
            Console.WriteLine("Soyadınız:");
            string kisisoyadi = Console.ReadLine();
            Console.WriteLine("Telefon numarası:");
            string telnom = Console.ReadLine();
            Console.WriteLine("Ad:" + kisiadi + "\t\tSoyad:" + kisisoyadi + "\t\tTelefon numarası:" + telnom);
        }
        private List<Salonlar> filmler;
        internal Biletkesim()
        {
            filmler = new List<Salonlar> { };
        }
        public void devam()
        {
            Salonlar s = filmler[3];
            Console.WriteLine(s.ToString());
        }
        public void FilmSec()
        {
            DateTime z = new DateTime(2021, 5, 12);
            string[] film = new string[] { "Halka", "Matrix", "Başlangıç", "Çelik Adam", "Bay Evet" };
            int[] saat = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("Film secimi yapiniz: (1-5)");
            for (int i = 0; i < film.Length; i++)
            {
                Console.WriteLine(i + 1 + "." + film[i]);
            }
            int secim3 = Convert.ToInt32(Console.ReadLine());
            switch (secim3)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Saat seciniz:");
                    Console.WriteLine("1 - 7");
                    int secim4 = Convert.ToInt32(Console.ReadLine());
                    switch (secim4)
                    {
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                            Console.WriteLine("Koltuk seciniz:");
                            Console.WriteLine("1-5");
                            int secim5 = Convert.ToInt32(Console.ReadLine());
                            switch (secim5)
                            {
                                case 1:
                                case 2:
                                case 3:
                                case 4:
                                case 5:
                                    Bilgi();
                                    Console.WriteLine("Film adı:" + film[secim3 - 1] + "\t\tsaati:" + saat[secim4] + "\t\ttarih:" + z + "\tkoltuk numarası:" + secim5 + "\tSalon numarası:" + "5");
                                    break;
                                default:
                                    Console.WriteLine("Yanlıs secim lütfen doğrusunu girin..."); break;
                            }
                            break;
                        default:
                            Console.WriteLine("Yanlıs secim lütfen doğrusunu girin..."); break;

                    }
                    break;
                default:
                    Console.WriteLine("Yanlıs secim lütfen doğrusunu girin..."); break;
            }
        }
        public void Anamenu()
        {
            Console.WriteLine("---ANA MENU--- \n 1.Film sec: \n 2.Çıkış:");
            int secim2 = Convert.ToInt32(Console.ReadLine());
            switch (secim2)
            {
                case 1:
                    FilmSec();
                    Anamenu();
                    break;
                case 2:
                    break;
            }
        }




    }
}
