using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirstODEV.Entities
{
    [Table("Siparisler")]
    public class Siparis
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Musteri")]
        public int MusteriID { get; set; }

        [Required, MaxLength(5), Column(TypeName = "nchar")]
        public string PizzaBoyu { get; set; }

        [Required, MaxLength(6), Column(TypeName = "nchar")]
        public string Icecek { get; set; }
        public short PizzaAdedi { get; set; }
        public short IcecekAdedi { get; set; }

        [Column(TypeName = "money")]
        public decimal Ucret { get; set; }

        [Required, MaxLength(60)]
        public string Malzeme { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime SiparisTarihi { get; set; }
        

        public virtual Musteri Musteri { get; set; }

    }
}
