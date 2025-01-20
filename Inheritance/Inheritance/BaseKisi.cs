using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class BaseKisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        // Method to display name and surname
        public void Yazdir()
        {
            Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}");
        }




    }
}
