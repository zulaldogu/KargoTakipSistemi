using System.ComponentModel.DataAnnotations;

namespace KargoTakipSistemi.Models
{
    public class Sube
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Şube adı zorunludur.")]
        [StringLength(100, ErrorMessage = "Şube adı en fazla 100 karakter olabilir.")]
        public string SubeAdi { get; set; } = string.Empty;

        [Required(ErrorMessage = "Şehir bilgisi zorunludur.")]
        [StringLength(50, ErrorMessage = "Şehir adı en fazla 50 karakter olabilir.")]
        public string Sehir { get; set; } = string.Empty;

        [Required(ErrorMessage = "Adres bilgisi zorunludur.")]
        [StringLength(200, ErrorMessage = "Adres en fazla 200 karakter olabilir.")]
        public string Adres { get; set; } = string.Empty;

        [Required(ErrorMessage = "Telefon numarası zorunludur.")]
        [StringLength(20, ErrorMessage = "Telefon numarası en fazla 20 karakter olabilir.")]
        public string Telefon { get; set; } = string.Empty;

        public ICollection<Kargo>? Kargolar { get; set; }
    }
}