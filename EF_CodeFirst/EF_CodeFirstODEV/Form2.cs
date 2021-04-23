using EF_CodeFirstODEV.Context;
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
    public partial class Form2 : Form
    {
        /*
        * CODE FIRST ÖDEV:
        * Form2 yüklendiğinde, ComboBox'ta müşteri adı soyadı bilgileri gelecek.
        * Müşteri seçilip, Kişinin Siparişini Gör butonuna tıklandığında, müşterinin sipariş detayları ilgili Label'da alt alta olacak şekilde bastırılacak.
        * Temizle butonuna tıklandığında Metotlar Class'ından Temizle() metodu ile ilgili alanlar temizlenecek
        * 
        */
        Form1 mainform;
        public Form2(Form1 frm)
        {
            mainform = frm;
            InitializeComponent();
        }

        private void btnGor_Click(object sender, EventArgs e)
        {
            var itemMusteri = db.Musteriler.FirstOrDefault(m => m.AdSoyad == cmbAdSoyad.Text);
            var itemSiparis = db.Siparisler.FirstOrDefault(s => s.MusteriID == itemMusteri.ID);

            lblSiparis.Text = $"AdSoyad: {itemMusteri.AdSoyad}\nTelefonu: {itemMusteri.Telefon}\nAdres: {itemSiparis.SiparisTarihi}\n{itemSiparis.PizzaAdedi} Adet {itemSiparis.PizzaBoyu} boy pizza {itemSiparis.IcecekAdedi} adet {itemSiparis.Icecek}\nSeçilen Malzemeler: {itemSiparis.Malzeme}\nÖdenmesi Gereken Tutar: {itemSiparis.Ucret}. TL";
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            cmbAdSoyad.Text = "";
            lblSiparis.Text = "";
        }

        private void btnDon_Click(object sender, EventArgs e)
        {
            mainform.Show();
            this.Hide();
        }

        ProjectContext db;
        private void Form2_Load(object sender, EventArgs e)
        {
            db = new ProjectContext();
            cmbAdSoyad.DataSource = db.Musteriler.ToList();
            cmbAdSoyad.DisplayMember = "AdSoyad";
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainform.Show();
        }
    }
}
