# Patika Kütüphanesi - Kitap Kayıt Uygulaması

Bu proje, kitap kayıtlarını tutmak ve kitap bilgilerini yönetmek için basit bir konsol uygulamasıdır. Kitap nesneleri `Book` sınıfı üzerinden oluşturulmaktadır. 

## Özellikler

- **Kitap Bilgileri:**
  - Ad
  - Yazar Adı
  - Yazar Soyadı
  - Sayfa Sayısı
  - Yayınevi
  - Kayıt Tarihi (otomatik olarak atanır)

- **Yapıcı Metotlar (Constructors):**
  - **Varsayılan Constructor (Default):**
    - Parametre almaz.
    - Kayıt tarihi otomatik olarak atanır.
  - **Parametreli Constructor:**
    - Kitap adı, yazar adı, sayfa sayısı ve yayınevi bilgilerini parametre olarak alır.
    - Kayıt tarihi yine otomatik olarak atanır.

## Kullanım

### Örnek Kod

#### Default Constructor Kullanımı
```csharp
Book book1 = new Book()
{
    Name = "Adı Aylin",
    WriterName = "Ayşe",
    WriterSurname = "Kulin",
    NumberOfPages = 398,
    Publisher = "Remzi Kitabevi"
};
````
#### Parametreli Constructor Kullanımı
```csharp
Book book2 = new Book("Sefiller", "Victor Hugo", 1724, "Can Yayınları");
````
#### Kitap Bilgilerini Yazdırma
```csharp
book1.Bookİnfo();
book2.Bookİnfo();
````
#### Beklenen Çıktı
```txt
Adı Sabırsız Yürek adlı kitap, Stefan Zweig tarafından yazılmıştır.
464 sayfa, Alfa Yayınları yayınevinden 09.01.2025 tarihinde kaydedildi.

Sefiller adlı kitap, Victor Hugo tarafından yazılmıştır.
1724 sayfa, Can Yayınları yayınevinden 09.01.2025 tarihinde kaydedildi.


