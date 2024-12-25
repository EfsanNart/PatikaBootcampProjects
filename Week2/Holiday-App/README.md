# Tatil Planlayıcı Uygulaması

Bu proje, kullanıcıların tatil planlamalarına yardımcı olan bir C# uygulamasıdır. Kullanıcılar, lokasyon seçimi, kişi sayısı, ulaşım türü gibi seçenekleri belirleyerek toplam tatil maliyetini hesaplayabilirler.

## Özellikler
- **Lokasyon Seçimi:** Kullanıcılar, Bodrum, Marmaris veya Çeşme gibi popüler tatil bölgelerinden birini seçebilirler.
- **Kişi Sayısı:** Kullanıcı, tatili kaç kişi için planladığını belirleyebilir.
- **Ulaşım Seçimi:** Kullanıcılar, kara yolu veya hava yolu gibi ulaşım seçeneklerinden birini tercih edebilirler.
- **Maliyet Hesaplama:** Seçilen lokasyon, kişi sayısı ve ulaşım türüne göre toplam tatil maliyeti hesaplanır.

## Kullanım
1. **Lokasyon Seçimi:**
    - Kullanıcı, Bodrum, Marmaris veya Çeşme arasından bir lokasyon seçer.
    - Her lokasyon için farklı fiyatlar mevcuttur.
  
2. **Kişi Sayısı Seçimi:**
    - Kullanıcı, tatil planını kaç kişi için yapacağını belirler.
  
3. **Ulaşım Seçimi:**
    - Kullanıcı, kara yolu (kişibaşı 1500 TL) ya da hava yolu (kişibaşı 4000 TL) seçeneklerinden birini seçer.
  
4. **Toplam Maliyet Hesaplama:**
    - Seçilen lokasyon ve ulaşım türüne göre toplam maliyet hesaplanır ve kullanıcıya gösterilir.

5. **Başka Bir Tatil Planı:**
    - Kullanıcı, başka bir tatil planı yapmak isteyip istemediği sorusuna yanıt vererek programı tekrar başlatabilir veya bitirebilir.

## Kod Açıklaması

### Ana Döngü
Program, ana bir sonsuz `while (true)` döngüsüyle başlar. Bu döngü, kullanıcı başka bir tatil planlamak istemediği sürece devam eder.

### Lokasyon Seçimi
Kullanıcıdan geçerli bir lokasyon (Bodrum, Marmaris, Çeşme) seçmesi istenir. Yanlış girişlerde kullanıcıya hata mesajı verilir ve tekrar seçim yapması istenir.

### Kişi Sayısı Seçimi
Kullanıcıdan geçerli bir kişi sayısı girmesi beklenir. Geçerli bir sayı girilene kadar döngü devam eder.

### Ulaşım Seçimi
Kullanıcıdan ulaşım türü (kara yolu ya da hava yolu) seçmesi istenir. Yanlış girişler yapıldığında hata mesajı gösterilir ve seçim tekrar yapılır.

### Toplam Maliyet Hesaplama
Seçilen lokasyon ve ulaşım türüne göre toplam maliyet hesaplanır ve kullanıcıya gösterilir.

### Sonuç Gösterimi
Kullanıcıya toplam maliyet gösterilir. Ayrıca başka bir tatil planlayıp planlamadığı sorulur. Eğer "Hayır" denirse, uygulama sonlanır.


