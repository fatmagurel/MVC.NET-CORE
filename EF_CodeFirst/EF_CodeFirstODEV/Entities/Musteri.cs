using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirstODEV.Entities
{
    [Table("Musteriler")]
    public class Musteri
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(75), Required]
        public string AdSoyad { get; set; }

        [MaxLength(150), Required]
        public string Adres { get; set; }

        [MaxLength(15)]
        public string Telefon { get; set; }

        public virtual List<Siparis> Siparisler { get; set; }

    }
}
