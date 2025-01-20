using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Ogrenci : BaseKisi
    {
        public string OgrenciNo { get; set; }

        
        public void YazdirOgrenciBilgileri()
        {
            Console.WriteLine($"Öğrenci No: {OgrenciNo}, Ad: {Ad}, Soyad: {Soyad}");
        }



    }
}
