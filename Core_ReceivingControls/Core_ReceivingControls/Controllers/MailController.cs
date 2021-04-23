using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Core_ReceivingControls.Controllers
{
    public class MailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Index(IFormCollection koleksiyon)
        //{
        //    ViewBag.Bilgi = koleksiyon["txtBilgi"];

        //    return View();
        //}

        [HttpPost]
        public IActionResult Index(string txtEmail, string txtKonu, string txtBilgi, string txtIcerik)
        {
            SmtpClient sc = new SmtpClient();
            MailMessage msj = new MailMessage();
            try
            {
                sc.Credentials = new NetworkCredential("deneme@mail.com", "parolaGirilecek");//mail ve şifre adresini tutar.
                msj.To.Add(txtEmail);//MAİL BU ADRESE GİDER
                msj.From = new MailAddress("gondericiMailAdresi", "GönderenAdiSoyadi", Encoding.UTF8);
                msj.Subject = txtKonu;
                msj.SubjectEncoding = Encoding.UTF8;
                msj.Body = txtIcerik;
                msj.BodyEncoding = Encoding.UTF8;
                msj.IsBodyHtml = true;

                //smtp ayarları
                sc.EnableSsl = false;
                sc.Port = 465;
                sc.Host = "smtp.gmail.com";

                //tetikleme
                sc.Send(msj);

                msj.Dispose();//Mesaj ramden yok edilir.


                ViewBag.Bilgi = "Mail başarıyla gönderildi...";

            }
            catch (Exception)
            {
                ViewBag.Bilgi = "Mail Gönderiminde Hata!";
            }
            return View();
        }
    }
}
