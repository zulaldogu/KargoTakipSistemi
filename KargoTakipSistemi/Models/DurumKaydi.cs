using System.ComponentModel.DataAnnotations;

namespace KargoTakipSistemi.Models
{
    public class DurumKaydi
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Durum bilgisi zorunludur.")]
        [StringLength(100, ErrorMessage = "Durum bilgisi en fazla 100 karakter olabilir.")]
        public string Durum { get; set; } = string.Empty;

        [StringLength(250, ErrorMessage = "Açıklama en fazla 250 karakter olabilir.")]
        public string? Aciklama { get; set; }

        [Required(ErrorMessage = "Tarih bilgisi zorunludur.")]
        [DataType(DataType.DateTime)]
        public DateTime Tarih { get; set; }

        [Required(ErrorMessage = "Kargo seçimi zorunludur.")]
        public int KargoId { get; set; }

        public Kargo? Kargo { get; set; }
    }
}