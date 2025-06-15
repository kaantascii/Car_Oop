# Car_Oop# 🚗 Encapsulation Pratiği - Araba Sınıfı

Bu projede, C# dilinde nesne yönelimli programlamanın (OOP) temel kavramlarından biri olan **kapsülleme (encapsulation)** uygulanmıştır.

## 🎯 Amaç

`Araba` adında bir sınıf oluşturarak:
- Marka, Model, Renk ve Kapı Sayısı gibi özellikler tanımlanmıştır.
- **Kapı Sayısı** özelliği için kapsülleme yapılarak, yalnızca geçerli değerlerin (2 veya 4) atanması sağlanmıştır.
- Geçersiz bir değer girilirse kullanıcı uyarılır ve `-1` atanır.

## 🧱 Sınıf Özellikleri

| Özellik    | Tip       | Açıklama |
|------------|-----------|----------|
| Marka      | `string`  | Arabanın markası |
| Model      | `string`  | Arabanın modeli |
| Renk       | `string`  | Arabanın rengi |
| KapıSayisi | `int`     | **Yalnızca 2 veya 4 olabilir**. Aksi halde `-1` atanır. |

## 🔐 Encapsulation Açıklaması

`KapıSayisi` özelliği private bir alanla korunur ve `get` / `set` blokları ile yönetilir:

```csharp
private int kapiSayisi;

public int KapiSayisi
{
    get { return kapiSayisi; }
    set
    {
        if (value == 2 || value == 4)
        {
            kapiSayisi = value;
        }
        else
        {
            Console.WriteLine("❌ Geçersiz kapı sayısı! Sadece 2 veya 4 olabilir.");
            kapiSayisi = -1;
        }
    }
}
