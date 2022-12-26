using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace v6.Models
{
    public class Kullanici
    {
        [Key]
        public int KullaniciID { get; set; }

        [Required(ErrorMessage = "Bu alan zorunlu")]
        [MaxLength(50, ErrorMessage = "Luftden gecerli ad girinz")]
        [MinLength(3, ErrorMessage = "Luftden gecerli ad girinz")]
        public string KullaniciAd { get; set; }

        [Required(ErrorMessage = "Bu alan zorunlu")]
        [MaxLength(50, ErrorMessage = "Luftden gecerli soyad girinz")]
        [MinLength(3, ErrorMessage = "Luftden gecerli soyad girinz")]
        public string KullaniciSoyad { get; set; }

        [EmailAddress(ErrorMessage = "Gecerli bir mail adres girinz")]
        [Required(ErrorMessage = "Bu alan zorunlu")]
        public string mail { get; set; }

        [Required(ErrorMessage = "Bu alan zorunlu")]
        [MinLength(8, ErrorMessage = "Slifre en az 8 kariktar olmali")]
        [DataType(DataType.Password)]
        public string sifre { get; set; }

        [Required(ErrorMessage = "Bu alan zorunlu")]
        [Compare("sifre", ErrorMessage = "Sifreler eslesmiyor")]
        [DataType(DataType.Password)]
        public string sifreTekrar { get; set; }
        [Required(ErrorMessage = "Bu alan zorunlu")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DogumTarihi { get; set; }
        public bool admin { get; set; }
        public ICollection<Content> Contents { get; set; }
    }
}
