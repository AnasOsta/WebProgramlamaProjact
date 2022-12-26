using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace v6.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Bu alan zorunlu")]
        [MaxLength(50, ErrorMessage = "Luftden gecerli ad girinz")]
        [MinLength(3, ErrorMessage = "Luftden gecerli ad girinz")]
        [Display(Name = "KullaniciAd")]
        public string KullaniciAd { get; set; }

        [Required(ErrorMessage = "Bu alan zorunlu")]
        [MinLength(8, ErrorMessage = "Slifre en az 8 kariktar olmali")]
        [DataType(DataType.Password)]
        [Display(Name = "sifre")]
        public string sifre { get; set; }

    }
}
