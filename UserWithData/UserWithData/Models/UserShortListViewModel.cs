using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserWithData.Models
{
    public class UserShortListViewModel
    {
        [Display(Name = "Kullanıcı Kodu")]
        public long Id { get; set; }


        [Display(Name = "Kullanıcı Adı")]
        [MaxLength(50, ErrorMessage = "Kullanıcı Adı en fazla 50 karakter olabilir!")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Kullanıcı Adı boş geçilemez!")]
        public string Username { get; set; }


        [Display(Name = "EPosta")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


    }
}
