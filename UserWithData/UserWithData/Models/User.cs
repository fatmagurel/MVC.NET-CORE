using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace UserWithData.Models

{
    public enum TelefonTipleri { [Display(Name ="Phone")]cep, ev, iş, fax }
    public class User
    {
        [Display(Name = "Kullanıcı Kodu")]
        public long Id { get; set; }


        [Display(Name = "Kullanıcı Adı")]
        [MaxLength(50, ErrorMessage = "Kullanıcı Adı en fazla 50 karakter olabilir!")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Kullanıcı Adı boş geçilemez!")]
        public string Username { get; set; }


        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Girilen şifre en az 8 karakter olması gerekiyor!")]
        public string Password { get; set; }


        [Display(Name = "EPosta")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Display(Name = "Admin Kullanıcı")]
        [Required(ErrorMessage = "Admin kullanıcı seçimi boş geçilemez!")]
        public bool Admin { get; set; }


        [Display(Name = "Telefon Tip")]
        public TelefonTipleri PhoneType { get; set; }


        [Display(Name = "Telefon No")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Telefon formatında bilgi girmeniz gerekiyor!")]
        [StringLength(15, MinimumLength = 9, ErrorMessage = "9 ile 15 hane arasında giriş yapmalısınız!")]
        public string PhoneNumber { get; set; }


        [Display(Name = "Doğum Günü")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }


        [Display(Name = "Diğer Notlar")]
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }

    }
}
