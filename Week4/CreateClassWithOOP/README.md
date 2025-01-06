# Okul Yönetim Sistemi (C#)

Bu proje, okul yönetim sistemine ait temel özellikleri simüle eden bir C# uygulamasıdır. Öğrencilerin ve öğretmenlerin bilgilerini yönetmek için genel bir `Person` sınıfı oluşturulmuştur. Bu sınıf, öğrenci ve öğretmenler için ortak özellikleri barındırır ve her iki grup için bilgi yazdırma metotlarına sahiptir.

## Proje İçeriği

- **Person Sınıfı:** Öğrenciler ve öğretmenler için temel bilgileri içeren bir sınıf.
  - `Ad` (string): Kişinin adı.
  - `Soyad` (string): Kişinin soyadı.
  - `DogumTarihi` (DateTime): Kişinin doğum tarihi.
  - `Branş` (string): Öğretmenler için branş bilgisi.
  - `Sınıf` (string): Öğrenciler için sınıf bilgisi.

- **OgrenciInfo Metodu:** Öğrencilerin bilgilerini ekrana yazdırır.
- **OgretmenInfo Metodu:** Öğretmenlerin bilgilerini ekrana yazdırır.

## Özellikler

- Öğrenci ve öğretmen nesneleri oluşturulabilir.
- Her bir nesne için ad, soyad, doğum tarihi gibi bilgileri atayarak, uygun metoda çağrılar yapılabilir.
- Öğrencinin sınıfı ve öğretmenin branşı bilgileri doğru şekilde ekrana yazdırılır.

## Kullanım

Proje, C# ile geliştirilmiştir. Uygulamayı çalıştırmak için aşağıdaki adımları takip edebilirsiniz:

### Gereksinimler

- Visual Studio veya C# uyumlu bir geliştirme ortamı.
- .NET Framework veya .NET Core/5+ yüklü bir sistem.

### Çalıştırma

1. Projeyi bir C# geliştirme ortamına (Visual Studio, Visual Studio Code vb.) açın.
2. `Program.cs` dosyasını çalıştırarak uygulamayı başlatın.
3. Öğrenci ve öğretmen bilgilerinin ekrana yazdırıldığını göreceksiniz.

### Örnek Çıktı

```txt
Efşan Nart adlı öğrencinin doğum tarihi: 17.03.2001 'dir ve Back-End Web Developer sınıfındadır.
Sertan Bozkuş adlı öğretmenin doğum tarihi: 12.07.1996 'dır ve branşı Yazılım'dır.
