# 🚚 T&Z Ekspres - Kargo Takip Sistemi

**T&Z Ekspres Lojistik A.Ş.** için geliştirilmiş, kargo şubelerini, gönderi kayıtlarını ve anlık transfer hareketlerini tek bir merkezden yönetmeyi sağlayan ASP.NET Core MVC tabanlı web otomasyonudur.

## 🌟 Projenin Amacı ve Özellikleri
Bu proje, bir lojistik firmasının temel operasyonlarını dijitalleştirmek amacıyla tasarlanmıştır. Karmaşık veritabanı ID'leri yerine kullanıcı dostu arayüzler sunarak operasyon hızını artırmayı hedefler.

* **🏢 Şube Yönetimi:** Sisteme yeni dağıtım ve transfer merkezleri eklenebilir, mevcut şubeler güncellenebilir veya silinebilir.
* **📦 Kargo İşlemleri:** Gönderici, alıcı ve takip numarası bilgileriyle sisteme yeni kargolar tanımlanır ve bulundukları şubelerle eşleştirilir.
* **⏱️ Anlık Durum Takibi:** Kargoların "Şubeden Alındı", "Transfer Merkezine Sevk Edildi" veya "Teslim Edildi" gibi aşamaları tarih ve saat bilgisiyle birlikte sisteme işlenir.
* **✨ Profesyonel Arayüz:** Kullanıcı deneyimini (UX) ön planda tutan, Bootstrap altyapısıyla geliştirilmiş modern, temiz ve responsive (mobil uyumlu) bir tasarım kullanılmıştır.

## 🛠️ Kullanılan Teknolojiler
* **Backend:** C#, ASP.NET Core MVC
* **Veritabanı Yönetimi:** Entity Framework Core (Eager Loading & LINQ)
* **Frontend:** HTML5, CSS3, Bootstrap 5, Razor Syntax (`.cshtml`)
* **İkonlar:** FontAwesome 6

## 💡 Teknik Çözümler ve İyileştirmeler
Proje geliştirilirken standart otomatik kod (Scaffolding) üretiminin ötesine geçilerek aşağıdaki optimizasyonlar yapılmıştır:
* **Eager Loading (`Include`):** Veritabanı ilişkileri optimize edilerek, kargolar listelenirken şube adlarının performanslı bir şekilde çekilmesi sağlandı.
* **Güvenli Veri Gösterimi (`?` Operatörü):** Null-Conditional operatörler kullanılarak, boş gelebilecek verilerde uygulamanın çökmesi (NullReferenceException) engellendi.
* **Özelleştirilmiş Dropdown'lar:** Veri giriş formlarında `ViewBag` ve `SelectListItem` yapıları düzenlenerek, kullanıcıların anlamsız ID numaraları yerine "Takip Numarası" ve "Şube Adı" gibi net bilgileri seçmesi sağlandı.

## 🚀 Projeyi Çalıştırma (Kurulum)
1. Bu repoyu bilgisayarınıza klonlayın:
   ```bash
   git clone [https://github.com/zulaldogu/KargoTakipSistemi.git]
