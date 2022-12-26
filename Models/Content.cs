using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace v6.Models
{
    public class Content
    {
        [Key]
        public int ContentID { get; set; }
        [Required(ErrorMessage = "Bu alan zorunlu")]
        public string adi { get; set; }
        [Required(ErrorMessage = "Bu alan zorunlu")]
        public string imageUrl { get; set; }
        [Required(ErrorMessage = "Bu alan zorunlu")]
        public string tur { get; set; }
        [Required(ErrorMessage = "Bu alan zorunlu")]
        public string balslik { get; set; }
        [Required(ErrorMessage = "Bu alan zorunlu")]
        public string content { get; set; }
        public int KullaniciID { get; set; }
        public Kullanici Kullanici { get; set; }
    }
}
