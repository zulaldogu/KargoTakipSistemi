using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KargoTakipSistemi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subeler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubeAdi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Sehir = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subeler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kargolar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TakipNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GondericiAd = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AliciAd = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AliciAdres = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    GonderimTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TeslimTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SubeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kargolar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kargolar_Subeler_SubeId",
                        column: x => x.SubeId,
                        principalTable: "Subeler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DurumKayitlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Durum = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KargoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DurumKayitlari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DurumKayitlari_Kargolar_KargoId",
                        column: x => x.KargoId,
                        principalTable: "Kargolar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DurumKayitlari_KargoId",
                table: "DurumKayitlari",
                column: "KargoId");

            migrationBuilder.CreateIndex(
                name: "IX_Kargolar_SubeId",
                table: "Kargolar",
                column: "SubeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DurumKayitlari");

            migrationBuilder.DropTable(
                name: "Kargolar");

            migrationBuilder.DropTable(
                name: "Subeler");
        }
    }
}
