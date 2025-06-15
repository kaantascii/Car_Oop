class Program
{
    static void Main()
    {
        Araba araba1 = new Araba();
        araba1.Marka = "Opel";
        araba1.Model = "Corsa";
        araba1.Renk = "Beyaz";
        araba1.KapiSayisi = 4; // Geçerli kapı sayısı

        Console.WriteLine($" {araba1.Marka} {araba1.Model} - {araba1.Renk} - Kapı: {araba1.KapiSayisi}");

        Araba araba2 = new Araba(); // Yeni bir Araba nesnesi oluşturma
        araba2.Marka = "BMW";
        araba2.Model = "M3";
        araba2.Renk = "Siyah";
        araba2.KapiSayisi = 3; // Geçersiz!

        Console.WriteLine($" {araba2.Marka} {araba2.Model} - {araba2.Renk} - Kapı: {araba2.KapiSayisi}");
    }
}
