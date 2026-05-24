using KargoTakipSistemi.Models;
using Microsoft.EntityFrameworkCore;

namespace KargoTakipSistemi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Kargo> Kargolar { get; set; }

        public DbSet<Sube> Subeler { get; set; }

        public DbSet<DurumKaydi> DurumKayitlari { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Sube>().HasData(
                new Sube { Id = 1, SubeAdi = "Merkez Şube", Sehir = "Karaman", Adres = "Merkez Mahallesi Atatürk Bulvarı No:10", Telefon = "0338 212 00 01" },
                new Sube { Id = 2, SubeAdi = "İstanbul Transfer Merkezi", Sehir = "İstanbul", Adres = "Esenler Lojistik Bölgesi No:45", Telefon = "0212 555 34 34" },
                new Sube { Id = 3, SubeAdi = "Ankara Dağıtım Şubesi", Sehir = "Ankara", Adres = "Çankaya Mahallesi Tunus Caddesi No:18", Telefon = "0312 444 06 06" },
                new Sube { Id = 4, SubeAdi = "Konya Şubesi", Sehir = "Konya", Adres = "Selçuklu Mahallesi Lojistik Sokak No:7", Telefon = "0332 222 11 22" },
                new Sube { Id = 5, SubeAdi = "İzmir Şubesi", Sehir = "İzmir", Adres = "Bornova Mahallesi Kargo Caddesi No:21", Telefon = "0232 333 45 45" },
                new Sube { Id = 6, SubeAdi = "Bursa Dağıtım Merkezi", Sehir = "Bursa", Adres = "Nilüfer Organize Sanayi Bölgesi No:9", Telefon = "0224 555 12 12" },
                new Sube { Id = 7, SubeAdi = "Antalya Şubesi", Sehir = "Antalya", Adres = "Muratpaşa Mahallesi Lojistik Bulvarı No:16", Telefon = "0242 444 07 07" },
                new Sube { Id = 8, SubeAdi = "Adana Transfer Şubesi", Sehir = "Adana", Adres = "Seyhan Mahallesi Kargo Sokak No:5", Telefon = "0322 666 23 23" },
                new Sube { Id = 9, SubeAdi = "Kayseri Şubesi", Sehir = "Kayseri", Adres = "Melikgazi Mahallesi Sanayi Caddesi No:30", Telefon = "0352 777 18 18" },
                new Sube { Id = 10, SubeAdi = "Trabzon Şubesi", Sehir = "Trabzon", Adres = "Ortahisar Mahallesi Liman Caddesi No:11", Telefon = "0462 888 61 61" }
            );

            modelBuilder.Entity<Kargo>().HasData(
                new Kargo { Id = 1, TakipNo = "KRG001", GondericiAd = "Zülal Doğu", AliciAd = "Ayşe Yılmaz", AliciAdres = "İstanbul / Kadıköy", GonderimTarihi = new DateTime(2026, 5, 20), TeslimTarihi = null, SubeId = 1 },
                new Kargo { Id = 2, TakipNo = "KRG002", GondericiAd = "Mehmet Kaya", AliciAd = "Elif Demir", AliciAdres = "Ankara / Çankaya", GonderimTarihi = new DateTime(2026, 5, 21), TeslimTarihi = null, SubeId = 2 },
                new Kargo { Id = 3, TakipNo = "KRG003", GondericiAd = "Fatma Şahin", AliciAd = "Ahmet Koç", AliciAdres = "Konya / Selçuklu", GonderimTarihi = new DateTime(2026, 5, 22), TeslimTarihi = new DateTime(2026, 5, 24), SubeId = 4 },
                new Kargo { Id = 4, TakipNo = "KRG004", GondericiAd = "Can Arslan", AliciAd = "Merve Aydın", AliciAdres = "Karaman / Merkez", GonderimTarihi = new DateTime(2026, 5, 23), TeslimTarihi = null, SubeId = 3 },
                new Kargo { Id = 5, TakipNo = "KRG005", GondericiAd = "Selin Aksoy", AliciAd = "Burak Yıldız", AliciAdres = "İzmir / Bornova", GonderimTarihi = new DateTime(2026, 5, 18), TeslimTarihi = new DateTime(2026, 5, 21), SubeId = 5 },
                new Kargo { Id = 6, TakipNo = "KRG006", GondericiAd = "Emre Çelik", AliciAd = "Deniz Kurt", AliciAdres = "Bursa / Nilüfer", GonderimTarihi = new DateTime(2026, 5, 19), TeslimTarihi = null, SubeId = 6 },
                new Kargo { Id = 7, TakipNo = "KRG007", GondericiAd = "Gamze Polat", AliciAd = "Hakan Öz", AliciAdres = "Antalya / Muratpaşa", GonderimTarihi = new DateTime(2026, 5, 20), TeslimTarihi = null, SubeId = 7 },
                new Kargo { Id = 8, TakipNo = "KRG008", GondericiAd = "Ali Yavuz", AliciAd = "Seda Kılıç", AliciAdres = "Adana / Seyhan", GonderimTarihi = new DateTime(2026, 5, 17), TeslimTarihi = new DateTime(2026, 5, 20), SubeId = 8 },
                new Kargo { Id = 9, TakipNo = "KRG009", GondericiAd = "Buse Acar", AliciAd = "Onur Eren", AliciAdres = "Kayseri / Melikgazi", GonderimTarihi = new DateTime(2026, 5, 21), TeslimTarihi = null, SubeId = 9 },
                new Kargo { Id = 10, TakipNo = "KRG010", GondericiAd = "Kerem Uslu", AliciAd = "Derya Güneş", AliciAdres = "Trabzon / Ortahisar", GonderimTarihi = new DateTime(2026, 5, 22), TeslimTarihi = null, SubeId = 10 },
                new Kargo { Id = 11, TakipNo = "KRG011", GondericiAd = "Ece Yıldırım", AliciAd = "Tolga Can", AliciAdres = "İstanbul / Beşiktaş", GonderimTarihi = new DateTime(2026, 5, 23), TeslimTarihi = null, SubeId = 2 },
                new Kargo { Id = 12, TakipNo = "KRG012", GondericiAd = "Furkan Taş", AliciAd = "Nazlı Ersoy", AliciAdres = "Ankara / Keçiören", GonderimTarihi = new DateTime(2026, 5, 24), TeslimTarihi = null, SubeId = 3 },
                new Kargo { Id = 13, TakipNo = "KRG013", GondericiAd = "Melis Kara", AliciAd = "Cem Avcı", AliciAdres = "İzmir / Karşıyaka", GonderimTarihi = new DateTime(2026, 5, 24), TeslimTarihi = null, SubeId = 5 },
                new Kargo { Id = 14, TakipNo = "KRG014", GondericiAd = "Oğuzhan Demir", AliciAd = "İrem Bulut", AliciAdres = "Bursa / Osmangazi", GonderimTarihi = new DateTime(2026, 5, 25), TeslimTarihi = null, SubeId = 6 },
                new Kargo { Id = 15, TakipNo = "KRG015", GondericiAd = "Nisa Kaplan", AliciAd = "Yusuf Arı", AliciAdres = "Karaman / Üniversite Mahallesi", GonderimTarihi = new DateTime(2026, 5, 25), TeslimTarihi = null, SubeId = 1 }
            );

            modelBuilder.Entity<DurumKaydi>().HasData(
                new DurumKaydi { Id = 1, KargoId = 1, Durum = "Kargo alındı", Aciklama = "Kargo Merkez Şube tarafından teslim alındı.", Tarih = new DateTime(2026, 5, 20, 9, 30, 0) },
                new DurumKaydi { Id = 2, KargoId = 1, Durum = "Transfer merkezinde", Aciklama = "Kargo İstanbul Transfer Merkezi'ne yönlendirildi.", Tarih = new DateTime(2026, 5, 21, 14, 15, 0) },
                new DurumKaydi { Id = 3, KargoId = 1, Durum = "Dağıtıma çıktı", Aciklama = "Kargo alıcı adresine teslim edilmek üzere dağıtıma çıkarıldı.", Tarih = new DateTime(2026, 5, 24, 10, 0, 0) },

                new DurumKaydi { Id = 4, KargoId = 2, Durum = "Kargo alındı", Aciklama = "Kargo göndericiden teslim alındı.", Tarih = new DateTime(2026, 5, 21, 11, 45, 0) },
                new DurumKaydi { Id = 5, KargoId = 2, Durum = "Transfer merkezinde", Aciklama = "Kargo Ankara Dağıtım Şubesi'ne sevk edildi.", Tarih = new DateTime(2026, 5, 22, 16, 20, 0) },

                new DurumKaydi { Id = 6, KargoId = 3, Durum = "Kargo alındı", Aciklama = "Kargo Konya Şubesi tarafından teslim alındı.", Tarih = new DateTime(2026, 5, 22, 8, 40, 0) },
                new DurumKaydi { Id = 7, KargoId = 3, Durum = "Dağıtıma çıktı", Aciklama = "Kargo alıcı adresine teslim için dağıtıma çıkarıldı.", Tarih = new DateTime(2026, 5, 24, 9, 10, 0) },
                new DurumKaydi { Id = 8, KargoId = 3, Durum = "Teslim edildi", Aciklama = "Kargo alıcıya başarıyla teslim edildi.", Tarih = new DateTime(2026, 5, 24, 15, 30, 0) },

                new DurumKaydi { Id = 9, KargoId = 4, Durum = "Kargo alındı", Aciklama = "Kargo Ankara Dağıtım Şubesi tarafından sisteme kaydedildi.", Tarih = new DateTime(2026, 5, 23, 13, 0, 0) },
                new DurumKaydi { Id = 10, KargoId = 4, Durum = "Transfer merkezinde", Aciklama = "Kargo Karaman Merkez Şube'ye yönlendirildi.", Tarih = new DateTime(2026, 5, 24, 9, 50, 0) },

                new DurumKaydi { Id = 11, KargoId = 5, Durum = "Kargo alındı", Aciklama = "Kargo İzmir Şubesi tarafından teslim alındı.", Tarih = new DateTime(2026, 5, 18, 10, 20, 0) },
                new DurumKaydi { Id = 12, KargoId = 5, Durum = "Dağıtıma çıktı", Aciklama = "Kargo alıcı adresine dağıtıma çıkarıldı.", Tarih = new DateTime(2026, 5, 21, 9, 0, 0) },
                new DurumKaydi { Id = 13, KargoId = 5, Durum = "Teslim edildi", Aciklama = "Kargo teslim edildi.", Tarih = new DateTime(2026, 5, 21, 16, 10, 0) },

                new DurumKaydi { Id = 14, KargoId = 6, Durum = "Kargo alındı", Aciklama = "Kargo Bursa Dağıtım Merkezi'ne kaydedildi.", Tarih = new DateTime(2026, 5, 19, 12, 30, 0) },
                new DurumKaydi { Id = 15, KargoId = 6, Durum = "Transfer merkezinde", Aciklama = "Kargo transfer işlemi için bekliyor.", Tarih = new DateTime(2026, 5, 20, 17, 45, 0) },

                new DurumKaydi { Id = 16, KargoId = 7, Durum = "Kargo alındı", Aciklama = "Kargo Antalya Şubesi tarafından teslim alındı.", Tarih = new DateTime(2026, 5, 20, 15, 10, 0) },
                new DurumKaydi { Id = 17, KargoId = 7, Durum = "Transfer merkezinde", Aciklama = "Kargo şehir içi dağıtım merkezine gönderildi.", Tarih = new DateTime(2026, 5, 21, 10, 35, 0) },
                new DurumKaydi { Id = 18, KargoId = 7, Durum = "Dağıtıma çıktı", Aciklama = "Kargo kurye tarafından dağıtıma çıkarıldı.", Tarih = new DateTime(2026, 5, 22, 8, 50, 0) },

                new DurumKaydi { Id = 19, KargoId = 8, Durum = "Kargo alındı", Aciklama = "Kargo Adana Transfer Şubesi tarafından alındı.", Tarih = new DateTime(2026, 5, 17, 9, 25, 0) },
                new DurumKaydi { Id = 20, KargoId = 8, Durum = "Teslim edildi", Aciklama = "Kargo alıcıya teslim edildi.", Tarih = new DateTime(2026, 5, 20, 14, 40, 0) },

                new DurumKaydi { Id = 21, KargoId = 9, Durum = "Kargo alındı", Aciklama = "Kargo Kayseri Şubesi tarafından sisteme eklendi.", Tarih = new DateTime(2026, 5, 21, 13, 15, 0) },
                new DurumKaydi { Id = 22, KargoId = 9, Durum = "Transfer merkezinde", Aciklama = "Kargo transfer merkezinde işlem görüyor.", Tarih = new DateTime(2026, 5, 22, 18, 5, 0) },

                new DurumKaydi { Id = 23, KargoId = 10, Durum = "Kargo alındı", Aciklama = "Kargo Trabzon Şubesi tarafından teslim alındı.", Tarih = new DateTime(2026, 5, 22, 11, 0, 0) },
                new DurumKaydi { Id = 24, KargoId = 10, Durum = "Transfer merkezinde", Aciklama = "Kargo bölgesel transfer merkezine gönderildi.", Tarih = new DateTime(2026, 5, 23, 10, 25, 0) },

                new DurumKaydi { Id = 25, KargoId = 11, Durum = "Kargo alındı", Aciklama = "Kargo İstanbul Transfer Merkezi'nde kayıt altına alındı.", Tarih = new DateTime(2026, 5, 23, 9, 0, 0) },
                new DurumKaydi { Id = 26, KargoId = 11, Durum = "Dağıtıma çıktı", Aciklama = "Kargo dağıtıma çıkarıldı.", Tarih = new DateTime(2026, 5, 24, 13, 10, 0) },

                new DurumKaydi { Id = 27, KargoId = 12, Durum = "Kargo alındı", Aciklama = "Kargo Ankara Dağıtım Şubesi'nde teslim alındı.", Tarih = new DateTime(2026, 5, 24, 10, 40, 0) },
                new DurumKaydi { Id = 28, KargoId = 12, Durum = "Transfer merkezinde", Aciklama = "Kargo teslimat öncesi transfer merkezinde bekliyor.", Tarih = new DateTime(2026, 5, 25, 9, 20, 0) },

                new DurumKaydi { Id = 29, KargoId = 13, Durum = "Kargo alındı", Aciklama = "Kargo İzmir Şubesi tarafından alındı.", Tarih = new DateTime(2026, 5, 24, 14, 0, 0) },
                new DurumKaydi { Id = 30, KargoId = 13, Durum = "Transfer merkezinde", Aciklama = "Kargo şehir içi transfer sürecinde.", Tarih = new DateTime(2026, 5, 25, 11, 15, 0) },

                new DurumKaydi { Id = 31, KargoId = 14, Durum = "Kargo alındı", Aciklama = "Kargo Bursa Dağıtım Merkezi'ne teslim edildi.", Tarih = new DateTime(2026, 5, 25, 8, 30, 0) },
                new DurumKaydi { Id = 32, KargoId = 14, Durum = "Transfer merkezinde", Aciklama = "Kargo transfer merkezinde işleme alındı.", Tarih = new DateTime(2026, 5, 25, 15, 45, 0) },

                new DurumKaydi { Id = 33, KargoId = 15, Durum = "Kargo alındı", Aciklama = "Kargo Merkez Şube tarafından teslim alındı.", Tarih = new DateTime(2026, 5, 25, 9, 10, 0) },
                new DurumKaydi { Id = 34, KargoId = 15, Durum = "Transfer merkezinde", Aciklama = "Kargo dağıtım için hazırlanıyor.", Tarih = new DateTime(2026, 5, 25, 12, 50, 0) },
                new DurumKaydi { Id = 35, KargoId = 15, Durum = "Dağıtıma çıktı", Aciklama = "Kargo alıcı adresine teslim edilmek üzere dağıtıma çıkarıldı.", Tarih = new DateTime(2026, 5, 26, 9, 30, 0) }
            );
        }
    }
}