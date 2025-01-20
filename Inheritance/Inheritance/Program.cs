using Inheritance;

public class Program
{
    public static void Main(string[] args)
    {
        // Öğrenci nesnesi oluşturma
        Ogrenci ogrenci = new Ogrenci
        {
            Ad = "Ahmet",
            Soyad = "Yılmaz",
            OgrenciNo = "12345"
        };

        // Öğrenci bilgilerini yazdırma
        ogrenci.YazdirOgrenciBilgileri();

        // Öğretmen nesnesi oluşturma
        Ogretmen ogretmen = new Ogretmen
        {
            Ad = "Murat",
            Soyad = "Kara",
            Maas = 5000m
        };

        // Öğretmen bilgilerini yazdırma
        ogretmen.YazdirOgretmenBilgileri();
    }
}