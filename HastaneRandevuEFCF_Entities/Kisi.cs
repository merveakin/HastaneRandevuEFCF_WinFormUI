using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuEFCF_Entities
{
    public abstract class Kisi
    {
        [Required]
        [StringLength(11)]
        public string TCNumarasi { get; set; }

        [StringLength(11)]  //05392609129
        public string Telefon { get; set; }

        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Lütfen email adresinizi doğru biçimde giriniz.")]
        public string Email { get; set; }
    }
}
