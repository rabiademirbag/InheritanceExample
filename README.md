# C# Kalıtım (Inheritance) Örneği - BaseKisi, Ogrenci ve Ogretmen

Bu basit C# uygulaması, nesne tabanlı programlamada **kalıtım (inheritance)** kavramını göstermek amacıyla geliştirilmiştir. Uygulamada bir temel sınıf (BaseKisi) tanımlanmış ve bu sınıftan türeyen Ogrenci ve Ogretmen sınıfları ile örnekler yapılmıştır.

## İçerik

- `BaseKisi` sınıfı: Ad ve Soyad özelliklerine sahiptir. Bu bilgileri ekrana yazdıran bir metodu vardır.
- `Ogrenci` sınıfı: `BaseKisi` sınıfından türemiştir. Ek olarak Öğrenci Numarası özelliği vardır. Tüm bilgileri yazdıran bir metodu içerir.
- `Ogretmen` sınıfı: `BaseKisi` sınıfından türemiştir. Ek olarak Maaş bilgisi içerir. Tüm bilgileri yazdıran bir metodu içerir.
- `Program.cs`: Öğrenci ve öğretmen nesneleri oluşturularak bilgiler konsola yazdırılır.
