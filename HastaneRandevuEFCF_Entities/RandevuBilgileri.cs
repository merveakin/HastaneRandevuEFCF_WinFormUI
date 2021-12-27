using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuEFCF_Entities
{
    [Table("RandevuBilgileri")]

    public class RandevuBilgileri
    {
        [Key]
        [Column(Order = 1)]
        public int Id { get; set; }
        public int DoktorId { get; set; }
        public int HastaId { get; set; }
        public DateTime RandevuTarihi { get; set; }

        //İLİŞKİ

        [ForeignKey("DoktorId")]
        public virtual Doktor Doktor { get; set; }

        [ForeignKey("HastaId")]
        public virtual Hasta Hasta { get; set; }



    }
}
