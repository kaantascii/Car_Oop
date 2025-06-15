using System;

class Araba
{
    // Public erişilebilir özellikler
    public string Marka;
    public string Model;
    public string Renk;

    // Özel değişken (private field)
    private int kapiSayisi;

    // Kapsüllenmiş özellik (Property)
    public int KapiSayisi
    {
        get
        {
            return kapiSayisi;
        }
        set
        {
            if (value == 2 || value == 4)
            {
                kapiSayisi = value;
            }
            else
            {
                Console.WriteLine(" Geçersiz kapı sayısı! Sadece 2 veya 4 olabilir.");
                kapiSayisi = -1;
            }
        }
    }
}
