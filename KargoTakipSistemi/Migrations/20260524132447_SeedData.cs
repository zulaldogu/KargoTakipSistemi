using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KargoTakipSistemi.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Subeler",
                columns: new[] { "Id", "Adres", "Sehir", "SubeAdi", "Telefon" },
                values: new object[,]
                {
                    { 1, "Merkez Mahallesi Atatürk Bulvarı No:10", "Karaman", "Merkez Şube", "0338 212 00 01" },
                    { 2, "Esenler Lojistik Bölgesi No:45", "İstanbul", "İstanbul Transfer Merkezi", "0212 555 34 34" },
                    { 3, "Çankaya Mahallesi Tunus Caddesi No:18", "Ankara", "Ankara Dağıtım Şubesi", "0312 444 06 06" },
                    { 4, "Selçuklu Mahallesi Lojistik Sokak No:7", "Konya", "Konya Şubesi", "0332 222 11 22" },
                    { 5, "Bornova Mahallesi Kargo Caddesi No:21", "İzmir", "İzmir Şubesi", "0232 333 45 45" },
                    { 6, "Nilüfer Organize Sanayi Bölgesi No:9", "Bursa", "Bursa Dağıtım Merkezi", "0224 555 12 12" },
                    { 7, "Muratpaşa Mahallesi Lojistik Bulvarı No:16", "Antalya", "Antalya Şubesi", "0242 444 07 07" },
                    { 8, "Seyhan Mahallesi Kargo Sokak No:5", "Adana", "Adana Transfer Şubesi", "0322 666 23 23" },
                    { 9, "Melikgazi Mahallesi Sanayi Caddesi No:30", "Kayseri", "Kayseri Şubesi", "0352 777 18 18" },
                    { 10, "Ortahisar Mahallesi Liman Caddesi No:11", "Trabzon", "Trabzon Şubesi", "0462 888 61 61" }
                });

            migrationBuilder.InsertData(
                table: "Kargolar",
                columns: new[] { "Id", "AliciAd", "AliciAdres", "GondericiAd", "GonderimTarihi", "SubeId", "TakipNo", "TeslimTarihi" },
                values: new object[,]
                {
                    { 1, "Ayşe Yılmaz", "İstanbul / Kadıköy", "Zülal Doğu", new DateTime(2026, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "KRG001", null },
                    { 2, "Elif Demir", "Ankara / Çankaya", "Mehmet Kaya", new DateTime(2026, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "KRG002", null },
                    { 3, "Ahmet Koç", "Konya / Selçuklu", "Fatma Şahin", new DateTime(2026, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "KRG003", new DateTime(2026, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Merve Aydın", "Karaman / Merkez", "Can Arslan", new DateTime(2026, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "KRG004", null },
                    { 5, "Burak Yıldız", "İzmir / Bornova", "Selin Aksoy", new DateTime(2026, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "KRG005", new DateTime(2026, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Deniz Kurt", "Bursa / Nilüfer", "Emre Çelik", new DateTime(2026, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "KRG006", null },
                    { 7, "Hakan Öz", "Antalya / Muratpaşa", "Gamze Polat", new DateTime(2026, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "KRG007", null },
                    { 8, "Seda Kılıç", "Adana / Seyhan", "Ali Yavuz", new DateTime(2026, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "KRG008", new DateTime(2026, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "Onur Eren", "Kayseri / Melikgazi", "Buse Acar", new DateTime(2026, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "KRG009", null },
                    { 10, "Derya Güneş", "Trabzon / Ortahisar", "Kerem Uslu", new DateTime(2026, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "KRG010", null },
                    { 11, "Tolga Can", "İstanbul / Beşiktaş", "Ece Yıldırım", new DateTime(2026, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "KRG011", null },
                    { 12, "Nazlı Ersoy", "Ankara / Keçiören", "Furkan Taş", new DateTime(2026, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "KRG012", null },
                    { 13, "Cem Avcı", "İzmir / Karşıyaka", "Melis Kara", new DateTime(2026, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "KRG013", null },
                    { 14, "İrem Bulut", "Bursa / Osmangazi", "Oğuzhan Demir", new DateTime(2026, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "KRG014", null },
                    { 15, "Yusuf Arı", "Karaman / Üniversite Mahallesi", "Nisa Kaplan", new DateTime(2026, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "KRG015", null }
                });

            migrationBuilder.InsertData(
                table: "DurumKayitlari",
                columns: new[] { "Id", "Aciklama", "Durum", "KargoId", "Tarih" },
                values: new object[,]
                {
                    { 1, "Kargo Merkez Şube tarafından teslim alındı.", "Kargo alındı", 1, new DateTime(2026, 5, 20, 9, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Kargo İstanbul Transfer Merkezi'ne yönlendirildi.", "Transfer merkezinde", 1, new DateTime(2026, 5, 21, 14, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Kargo alıcı adresine teslim edilmek üzere dağıtıma çıkarıldı.", "Dağıtıma çıktı", 1, new DateTime(2026, 5, 24, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Kargo göndericiden teslim alındı.", "Kargo alındı", 2, new DateTime(2026, 5, 21, 11, 45, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Kargo Ankara Dağıtım Şubesi'ne sevk edildi.", "Transfer merkezinde", 2, new DateTime(2026, 5, 22, 16, 20, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Kargo Konya Şubesi tarafından teslim alındı.", "Kargo alındı", 3, new DateTime(2026, 5, 22, 8, 40, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Kargo alıcı adresine teslim için dağıtıma çıkarıldı.", "Dağıtıma çıktı", 3, new DateTime(2026, 5, 24, 9, 10, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "Kargo alıcıya başarıyla teslim edildi.", "Teslim edildi", 3, new DateTime(2026, 5, 24, 15, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "Kargo Ankara Dağıtım Şubesi tarafından sisteme kaydedildi.", "Kargo alındı", 4, new DateTime(2026, 5, 23, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "Kargo Karaman Merkez Şube'ye yönlendirildi.", "Transfer merkezinde", 4, new DateTime(2026, 5, 24, 9, 50, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "Kargo İzmir Şubesi tarafından teslim alındı.", "Kargo alındı", 5, new DateTime(2026, 5, 18, 10, 20, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "Kargo alıcı adresine dağıtıma çıkarıldı.", "Dağıtıma çıktı", 5, new DateTime(2026, 5, 21, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, "Kargo teslim edildi.", "Teslim edildi", 5, new DateTime(2026, 5, 21, 16, 10, 0, 0, DateTimeKind.Unspecified) },
                    { 14, "Kargo Bursa Dağıtım Merkezi'ne kaydedildi.", "Kargo alındı", 6, new DateTime(2026, 5, 19, 12, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 15, "Kargo transfer işlemi için bekliyor.", "Transfer merkezinde", 6, new DateTime(2026, 5, 20, 17, 45, 0, 0, DateTimeKind.Unspecified) },
                    { 16, "Kargo Antalya Şubesi tarafından teslim alındı.", "Kargo alındı", 7, new DateTime(2026, 5, 20, 15, 10, 0, 0, DateTimeKind.Unspecified) },
                    { 17, "Kargo şehir içi dağıtım merkezine gönderildi.", "Transfer merkezinde", 7, new DateTime(2026, 5, 21, 10, 35, 0, 0, DateTimeKind.Unspecified) },
                    { 18, "Kargo kurye tarafından dağıtıma çıkarıldı.", "Dağıtıma çıktı", 7, new DateTime(2026, 5, 22, 8, 50, 0, 0, DateTimeKind.Unspecified) },
                    { 19, "Kargo Adana Transfer Şubesi tarafından alındı.", "Kargo alındı", 8, new DateTime(2026, 5, 17, 9, 25, 0, 0, DateTimeKind.Unspecified) },
                    { 20, "Kargo alıcıya teslim edildi.", "Teslim edildi", 8, new DateTime(2026, 5, 20, 14, 40, 0, 0, DateTimeKind.Unspecified) },
                    { 21, "Kargo Kayseri Şubesi tarafından sisteme eklendi.", "Kargo alındı", 9, new DateTime(2026, 5, 21, 13, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 22, "Kargo transfer merkezinde işlem görüyor.", "Transfer merkezinde", 9, new DateTime(2026, 5, 22, 18, 5, 0, 0, DateTimeKind.Unspecified) },
                    { 23, "Kargo Trabzon Şubesi tarafından teslim alındı.", "Kargo alındı", 10, new DateTime(2026, 5, 22, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, "Kargo bölgesel transfer merkezine gönderildi.", "Transfer merkezinde", 10, new DateTime(2026, 5, 23, 10, 25, 0, 0, DateTimeKind.Unspecified) },
                    { 25, "Kargo İstanbul Transfer Merkezi'nde kayıt altına alındı.", "Kargo alındı", 11, new DateTime(2026, 5, 23, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, "Kargo dağıtıma çıkarıldı.", "Dağıtıma çıktı", 11, new DateTime(2026, 5, 24, 13, 10, 0, 0, DateTimeKind.Unspecified) },
                    { 27, "Kargo Ankara Dağıtım Şubesi'nde teslim alındı.", "Kargo alındı", 12, new DateTime(2026, 5, 24, 10, 40, 0, 0, DateTimeKind.Unspecified) },
                    { 28, "Kargo teslimat öncesi transfer merkezinde bekliyor.", "Transfer merkezinde", 12, new DateTime(2026, 5, 25, 9, 20, 0, 0, DateTimeKind.Unspecified) },
                    { 29, "Kargo İzmir Şubesi tarafından alındı.", "Kargo alındı", 13, new DateTime(2026, 5, 24, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, "Kargo şehir içi transfer sürecinde.", "Transfer merkezinde", 13, new DateTime(2026, 5, 25, 11, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 31, "Kargo Bursa Dağıtım Merkezi'ne teslim edildi.", "Kargo alındı", 14, new DateTime(2026, 5, 25, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 32, "Kargo transfer merkezinde işleme alındı.", "Transfer merkezinde", 14, new DateTime(2026, 5, 25, 15, 45, 0, 0, DateTimeKind.Unspecified) },
                    { 33, "Kargo Merkez Şube tarafından teslim alındı.", "Kargo alındı", 15, new DateTime(2026, 5, 25, 9, 10, 0, 0, DateTimeKind.Unspecified) },
                    { 34, "Kargo dağıtım için hazırlanıyor.", "Transfer merkezinde", 15, new DateTime(2026, 5, 25, 12, 50, 0, 0, DateTimeKind.Unspecified) },
                    { 35, "Kargo alıcı adresine teslim edilmek üzere dağıtıma çıkarıldı.", "Dağıtıma çıktı", 15, new DateTime(2026, 5, 26, 9, 30, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DurumKayitlari",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DurumKayitlari",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DurumKayitlari",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DurumKayitlari",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DurumKayitlari",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DurumKayitlari",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DurumKayitlari",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DurumKayitlari",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DurumKayitlari",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "DurumKayitlari",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "DurumKayitlari",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "DurumKayitlari",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "DurumKayitlari",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "DurumKayitlari",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "DurumKayitlari",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "DurumKayitlari",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "DurumKayitlari",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "DurumKayitlari",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "DurumKayitlari",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "DurumKayitlari",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "DurumKayitlari",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "DurumKayitlari",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "DurumKayitlari",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "DurumKayitlari",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "DurumKayitlari",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "DurumKayitlari",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "DurumKayitlari",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "DurumKayitlari",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "DurumKayitlari",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "DurumKayitlari",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "DurumKayitlari",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "DurumKayitlari",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "DurumKayitlari",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "DurumKayitlari",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "DurumKayitlari",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Kargolar",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Kargolar",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Kargolar",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Kargolar",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Kargolar",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Kargolar",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Kargolar",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Kargolar",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Kargolar",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Kargolar",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Kargolar",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Kargolar",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Kargolar",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Kargolar",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Kargolar",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Subeler",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subeler",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subeler",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subeler",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Subeler",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Subeler",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Subeler",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Subeler",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Subeler",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Subeler",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
