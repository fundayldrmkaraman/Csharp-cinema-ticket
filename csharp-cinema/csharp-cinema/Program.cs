using csharp_cinema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arasınav
{  // Program sınıfında biletkesim sınıfının içindeki anamenü metodunu nesne yardımıyla alarak sinema otomasyonunun giriş menüsünü oluştururuz.
    class Program
    {
        static void Main(string[] args)
        {
            Biletkesim a = new Biletkesim();
            a.Anamenu();
            Console.ReadKey();
        }
    }
}
