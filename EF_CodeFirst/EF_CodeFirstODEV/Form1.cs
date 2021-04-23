using EF_CodeFirstODEV.Context;
using EF_CodeFirstODEV.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_CodeFirstODEV
{
    public partial class Form1 : Form
    {
        /*
         * CODE FIRST ÖDEV:
         * Form yüklendiğinde, Sipariş Al butonu aktif, Temizle butonu pasif olacak.
         * Sipariş Al butonuna tıklandığında;
         * - BosAlanVarMi() metodu ile boş alan kontrolü yapılacak,
         * - MusteriAdSoyad bilgisi veritabanında varsa o müşteri için, yoksa yeni müşteri oluşturularak sipariş alınacak,
         * - Siparişin içindeki malzemeler, MalzemeleriGonder() metodu ile "-" ile ayrılmış şekilde checkBox'lardan çekilerek oluşturularak Sipariş'in Malzemeler'inde tutulacak.
         * - Siparişin ücreti, UcretHesaplama() metodu ile hesaplanacak ve siparişin ilgili alanında tutulacak.
         * - Sipariş alındığında "Siparişiniz alındı" mesajı yazdırılacak.
         * - İlgili butonlar aktif hale getirilecek.
         * - Tüm Siparişleri Gör butonuna tıklandığında, Form2 açılacak, Form1 gizlenecek.
         * Temizle butonuna tıklandığında Metotlar Class'ından Temizle() metodu ile ilgili alanlar temizlenecek
         * 
         */
        ProjectContext db;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new ProjectContext();
            btnTemizle.Enabled = false;
        }

        Musteri musteri = new Musteri();
        private void btnSiparisAl_Click(object sender, EventArgs e)
        {
            if(BosAlanVarMi())
                MessageBox.Show("Lütfen boş alanları doldurunuz!");
            else
            {
                if(db.Musteriler.FirstOrDefault(x => x.AdSoyad == txtAdSoyad.Text) == null)
                {
                    Musteri musteri = new Musteri()
                    {
                        AdSoyad = txtAdSoyad.Text,
                        Adres = txtAdres.Text,
                        Telefon = txtTelefon.Text
                    };
                    db.Musteriler.Add(musteri);
                    db.SaveChanges();
                }
            }
            var item = db.Musteriler.FirstOrDefault(x => x.AdSoyad == txtAdSoyad.Text);
            musteri.ID = item.ID;

            Siparis siparis = new Siparis()
            {
                MusteriID = musteri.ID,
                IcecekAdedi = (short)nmrIcecekAdedi.Value,
                PizzaAdedi = (short)nmrPizzaAdedi.Value,
                PizzaBoyu = cmbPizzaBoyu.Text,
                Malzeme = MalzemeleriGonder(),
                Icecek = cmbIcecek.Text,
                Ucret = UcretHesaplama(),
                SiparisTarihi = DateTime.Now
            };
            db.Siparisler.Add(siparis);
            db.SaveChanges();

            MessageBox.Show("Siparişiniz alındı!");
            btnTemizle.Enabled = true;
        }

        bool BosAlanVarMi()
        {
            foreach (Control item in grbMusteriBilgileri.Controls)
            {
                if(item is TextBox)
                {
                    if (item.Text == "") return true;
                }
                else if(item is ComboBox)
                {
                    if (item.Text == "") return true;
                }
            }
            if(nmrIcecekAdedi.Value == 0 || nmrPizzaAdedi.Value == 0)
            {
                return true;
            }
            foreach (Control item in grpMalzemeler.Controls)
            {
                if(item is CheckBox && ((CheckBox)item).Checked == true)
                {
                    return false;
                }
            }
            return false;//kontrol edelim
        }
        int UcretHesaplama()
        {
            int toplam = 0;
            if (cmbPizzaBoyu.Text == "Küçük")
            {
                toplam += 10 * (Convert.ToInt32(nmrPizzaAdedi.Value));
            }
            else if (cmbPizzaBoyu.Text == "Orta")
            {
                toplam += 15 * (Convert.ToInt32(nmrPizzaAdedi.Value));
            }
            else if (cmbPizzaBoyu.Text == "Büyük")
            {
                toplam += 20 * (Convert.ToInt32(nmrPizzaAdedi.Value));
            }

            if (cmbIcecek.Text == "Cola")
                toplam += 5 * (Convert.ToInt32(nmrIcecekAdedi.Value));
            else if (cmbIcecek.Text == "Fanta")
                toplam += 4 * (Convert.ToInt32(nmrIcecekAdedi.Value));
            else if (cmbIcecek.Text == "Sprite")
                toplam += 3 * (Convert.ToInt32(nmrIcecekAdedi.Value));

            
            return toplam;
        }

        string MalzemeleriGonder()
        {
            var result = string.Empty;
            foreach (Control item in grpMalzemeler.Controls)
            {
                CheckBox chk = item as CheckBox;//itemi checkbox olarak işaretleyip chk ye at.
                if(chk != null)
                {
                    if (chk.Checked)
                    {
                        if(result != string.Empty)
                        {
                            result += "-";
                        }
                        result += item.Text;
                    }
                }
            }
            return result;
        }

        private void btnSiparisleriGor_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(this);
            frm.Show();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            foreach (Control item in grbMusteriBilgileri.Controls)
            {
                if (item is TextBox) item.Text = "";
                else if (item is NumericUpDown)
                    ((NumericUpDown)item).Value = 0;
                else if (item is ComboBox) item.Text = "";
            }
            foreach (Control item in grpMalzemeler.Controls)
            {
                if (item is CheckBox)
                    ((CheckBox)item).Checked = false;
            }
        }
    }
}
