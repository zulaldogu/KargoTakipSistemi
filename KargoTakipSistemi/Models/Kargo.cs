using System.ComponentModel.DataAnnotations;

namespace KargoTakipSistemi.Models
{
    public class Kargo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Takip numarası zorunludur.")]
        [StringLength(30, ErrorMessage = "Takip numarası en fazla 30 karakter olabilir.")]
        public string TakipNo { get; set; } = string.Empty;

        [Required(ErrorMessage = "Gönderici adı zorunludur.")]
        [StringLength(100, ErrorMessage = "Gönderici adı en fazla 100 karakter olabilir.")]
        public string GondericiAd { get; set; } = string.Empty;

        [Required(ErrorMessage = "Alıcı adı zorunludur.")]
        [StringLength(100, ErrorMessage = "Alıcı adı en fazla 100 karakter olabilir.")]
        public string AliciAd { get; set; } = string.Empty;

        [Required(ErrorMessage = "Alıcı adresi zorunludur.")]
        [StringLength(250, ErrorMessage = "Alıcı adresi en fazla 250 karakter olabilir.")]
        public string AliciAdres { get; set; } = string.Empty;

        [Required(ErrorMessage = "Gönderim tarihi zorunludur.")]
        [DataType(DataType.Date)]
        public DateTime GonderimTarihi { get; set; }

        [DataType(DataType.Date)]
        public DateTime? TeslimTarihi { get; set; }

        [Required(ErrorMessage = "Şube seçimi zorunludur.")]
        public int SubeId { get; set; }

        public Sube? Sube { get; set; }

        public ICollection<DurumKaydi>? DurumKayitlari { get; set; }
    }
}