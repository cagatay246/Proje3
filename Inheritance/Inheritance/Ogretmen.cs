using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Ogretmen : BaseKisi
    {
        public decimal Maas { get; set; }

       
        public void YazdirOgretmenBilgileri()
        {
            Console.WriteLine($"Maaş: {Maas}, Ad: {Ad}, Soyad: {Soyad}");
        }





    }
}
