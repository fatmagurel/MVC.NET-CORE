
namespace EF_CodeFirstODEV
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSiparisleriGor = new System.Windows.Forms.Button();
            this.chkMantar = new System.Windows.Forms.CheckBox();
            this.chkSosis = new System.Windows.Forms.CheckBox();
            this.grpMalzemeler = new System.Windows.Forms.GroupBox();
            this.chkSogan = new System.Windows.Forms.CheckBox();
            this.chkZeytin = new System.Windows.Forms.CheckBox();
            this.chkSebze = new System.Windows.Forms.CheckBox();
            this.chkMisir = new System.Windows.Forms.CheckBox();
            this.chkKasar = new System.Windows.Forms.CheckBox();
            this.chkSucuk = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSiparisAl = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.nmrIcecekAdedi = new System.Windows.Forms.NumericUpDown();
            this.nmrPizzaAdedi = new System.Windows.Forms.NumericUpDown();
            this.cmbIcecek = new System.Windows.Forms.ComboBox();
            this.cmbPizzaBoyu = new System.Windows.Forms.ComboBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grbMusteriBilgileri = new System.Windows.Forms.GroupBox();
            this.grpMalzemeler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrIcecekAdedi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPizzaAdedi)).BeginInit();
            this.grbMusteriBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSiparisleriGor
            // 
            this.btnSiparisleriGor.Location = new System.Drawing.Point(438, 373);
            this.btnSiparisleriGor.Name = "btnSiparisleriGor";
            this.btnSiparisleriGor.Size = new System.Drawing.Size(158, 57);
            this.btnSiparisleriGor.TabIndex = 21;
            this.btnSiparisleriGor.Text = "TÜM SİPARİŞLERİ GÖR";
            this.btnSiparisleriGor.UseVisualStyleBackColor = true;
            this.btnSiparisleriGor.Click += new System.EventHandler(this.btnSiparisleriGor_Click);
            // 
            // chkMantar
            // 
            this.chkMantar.AutoSize = true;
            this.chkMantar.Location = new System.Drawing.Point(20, 106);
            this.chkMantar.Name = "chkMantar";
            this.chkMantar.Size = new System.Drawing.Size(59, 17);
            this.chkMantar.TabIndex = 0;
            this.chkMantar.Text = "Mantar";
            this.chkMantar.UseVisualStyleBackColor = true;
            // 
            // chkSosis
            // 
            this.chkSosis.AutoSize = true;
            this.chkSosis.Location = new System.Drawing.Point(20, 73);
            this.chkSosis.Name = "chkSosis";
            this.chkSosis.Size = new System.Drawing.Size(51, 17);
            this.chkSosis.TabIndex = 0;
            this.chkSosis.Text = "Sosis";
            this.chkSosis.UseVisualStyleBackColor = true;
            // 
            // grpMalzemeler
            // 
            this.grpMalzemeler.Controls.Add(this.chkSogan);
            this.grpMalzemeler.Controls.Add(this.chkMantar);
            this.grpMalzemeler.Controls.Add(this.chkSosis);
            this.grpMalzemeler.Controls.Add(this.chkZeytin);
            this.grpMalzemeler.Controls.Add(this.chkSebze);
            this.grpMalzemeler.Controls.Add(this.chkMisir);
            this.grpMalzemeler.Controls.Add(this.chkKasar);
            this.grpMalzemeler.Controls.Add(this.chkSucuk);
            this.grpMalzemeler.Location = new System.Drawing.Point(12, 254);
            this.grpMalzemeler.Name = "grpMalzemeler";
            this.grpMalzemeler.Size = new System.Drawing.Size(221, 176);
            this.grpMalzemeler.TabIndex = 19;
            this.grpMalzemeler.TabStop = false;
            this.grpMalzemeler.Text = "Malzemeler";
            // 
            // chkSogan
            // 
            this.chkSogan.AutoSize = true;
            this.chkSogan.Location = new System.Drawing.Point(20, 139);
            this.chkSogan.Name = "chkSogan";
            this.chkSogan.Size = new System.Drawing.Size(57, 17);
            this.chkSogan.TabIndex = 0;
            this.chkSogan.Text = "Soğan";
            this.chkSogan.UseVisualStyleBackColor = true;
            // 
            // chkZeytin
            // 
            this.chkZeytin.AutoSize = true;
            this.chkZeytin.Location = new System.Drawing.Point(132, 139);
            this.chkZeytin.Name = "chkZeytin";
            this.chkZeytin.Size = new System.Drawing.Size(55, 17);
            this.chkZeytin.TabIndex = 0;
            this.chkZeytin.Text = "Zeytin";
            this.chkZeytin.UseVisualStyleBackColor = true;
            // 
            // chkSebze
            // 
            this.chkSebze.AutoSize = true;
            this.chkSebze.Location = new System.Drawing.Point(132, 106);
            this.chkSebze.Name = "chkSebze";
            this.chkSebze.Size = new System.Drawing.Size(56, 17);
            this.chkSebze.TabIndex = 0;
            this.chkSebze.Text = "Sebze";
            this.chkSebze.UseVisualStyleBackColor = true;
            // 
            // chkMisir
            // 
            this.chkMisir.AutoSize = true;
            this.chkMisir.Location = new System.Drawing.Point(132, 73);
            this.chkMisir.Name = "chkMisir";
            this.chkMisir.Size = new System.Drawing.Size(47, 17);
            this.chkMisir.TabIndex = 0;
            this.chkMisir.Text = "Mısır";
            this.chkMisir.UseVisualStyleBackColor = true;
            // 
            // chkKasar
            // 
            this.chkKasar.AutoSize = true;
            this.chkKasar.Location = new System.Drawing.Point(132, 40);
            this.chkKasar.Name = "chkKasar";
            this.chkKasar.Size = new System.Drawing.Size(53, 17);
            this.chkKasar.TabIndex = 0;
            this.chkKasar.Text = "Kaşar";
            this.chkKasar.UseVisualStyleBackColor = true;
            // 
            // chkSucuk
            // 
            this.chkSucuk.AutoSize = true;
            this.chkSucuk.Location = new System.Drawing.Point(20, 40);
            this.chkSucuk.Name = "chkSucuk";
            this.chkSucuk.Size = new System.Drawing.Size(57, 17);
            this.chkSucuk.TabIndex = 0;
            this.chkSucuk.Text = "Sucuk";
            this.chkSucuk.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Telefonu :";
            // 
            // btnSiparisAl
            // 
            this.btnSiparisAl.Location = new System.Drawing.Point(262, 286);
            this.btnSiparisAl.Name = "btnSiparisAl";
            this.btnSiparisAl.Size = new System.Drawing.Size(155, 39);
            this.btnSiparisAl.TabIndex = 20;
            this.btnSiparisAl.Text = "SİPARİŞ AL";
            this.btnSiparisAl.UseVisualStyleBackColor = true;
            this.btnSiparisAl.Click += new System.EventHandler(this.btnSiparisAl_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pizza Boyu :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "İçecek :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "İçecek Adedi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Pizza Adedi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı Soyadı :";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(438, 286);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(158, 39);
            this.btnTemizle.TabIndex = 22;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // nmrIcecekAdedi
            // 
            this.nmrIcecekAdedi.Location = new System.Drawing.Point(455, 189);
            this.nmrIcecekAdedi.Name = "nmrIcecekAdedi";
            this.nmrIcecekAdedi.Size = new System.Drawing.Size(129, 20);
            this.nmrIcecekAdedi.TabIndex = 3;
            // 
            // nmrPizzaAdedi
            // 
            this.nmrPizzaAdedi.Location = new System.Drawing.Point(455, 149);
            this.nmrPizzaAdedi.Name = "nmrPizzaAdedi";
            this.nmrPizzaAdedi.Size = new System.Drawing.Size(129, 20);
            this.nmrPizzaAdedi.TabIndex = 3;
            // 
            // cmbIcecek
            // 
            this.cmbIcecek.FormattingEnabled = true;
            this.cmbIcecek.Items.AddRange(new object[] {
            "Cola",
            "Fanta",
            "Sprite"});
            this.cmbIcecek.Location = new System.Drawing.Point(128, 192);
            this.cmbIcecek.Name = "cmbIcecek";
            this.cmbIcecek.Size = new System.Drawing.Size(175, 21);
            this.cmbIcecek.TabIndex = 2;
            // 
            // cmbPizzaBoyu
            // 
            this.cmbPizzaBoyu.FormattingEnabled = true;
            this.cmbPizzaBoyu.Items.AddRange(new object[] {
            "Küçük",
            "Orta",
            "Büyük"});
            this.cmbPizzaBoyu.Location = new System.Drawing.Point(128, 149);
            this.cmbPizzaBoyu.Name = "cmbPizzaBoyu";
            this.cmbPizzaBoyu.Size = new System.Drawing.Size(175, 21);
            this.cmbPizzaBoyu.TabIndex = 2;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(128, 85);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(175, 20);
            this.txtTelefon.TabIndex = 1;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(395, 43);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(189, 68);
            this.txtAdres.TabIndex = 1;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(128, 43);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(175, 20);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Adresi :";
            // 
            // grbMusteriBilgileri
            // 
            this.grbMusteriBilgileri.Controls.Add(this.nmrIcecekAdedi);
            this.grbMusteriBilgileri.Controls.Add(this.nmrPizzaAdedi);
            this.grbMusteriBilgileri.Controls.Add(this.cmbIcecek);
            this.grbMusteriBilgileri.Controls.Add(this.cmbPizzaBoyu);
            this.grbMusteriBilgileri.Controls.Add(this.txtTelefon);
            this.grbMusteriBilgileri.Controls.Add(this.txtAdres);
            this.grbMusteriBilgileri.Controls.Add(this.txtAdSoyad);
            this.grbMusteriBilgileri.Controls.Add(this.label3);
            this.grbMusteriBilgileri.Controls.Add(this.label5);
            this.grbMusteriBilgileri.Controls.Add(this.label7);
            this.grbMusteriBilgileri.Controls.Add(this.label6);
            this.grbMusteriBilgileri.Controls.Add(this.label4);
            this.grbMusteriBilgileri.Controls.Add(this.label2);
            this.grbMusteriBilgileri.Controls.Add(this.label1);
            this.grbMusteriBilgileri.Location = new System.Drawing.Point(12, 12);
            this.grbMusteriBilgileri.Name = "grbMusteriBilgileri";
            this.grbMusteriBilgileri.Size = new System.Drawing.Size(602, 235);
            this.grbMusteriBilgileri.TabIndex = 18;
            this.grbMusteriBilgileri.TabStop = false;
            this.grbMusteriBilgileri.Text = "Müşteri Bilgileri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 453);
            this.Controls.Add(this.btnSiparisleriGor);
            this.Controls.Add(this.grpMalzemeler);
            this.Controls.Add(this.btnSiparisAl);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.grbMusteriBilgileri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpMalzemeler.ResumeLayout(false);
            this.grpMalzemeler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrIcecekAdedi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPizzaAdedi)).EndInit();
            this.grbMusteriBilgileri.ResumeLayout(false);
            this.grbMusteriBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSiparisleriGor;
        private System.Windows.Forms.CheckBox chkMantar;
        private System.Windows.Forms.CheckBox chkSosis;
        private System.Windows.Forms.GroupBox grpMalzemeler;
        private System.Windows.Forms.CheckBox chkSogan;
        private System.Windows.Forms.CheckBox chkZeytin;
        private System.Windows.Forms.CheckBox chkSebze;
        private System.Windows.Forms.CheckBox chkMisir;
        private System.Windows.Forms.CheckBox chkKasar;
        private System.Windows.Forms.CheckBox chkSucuk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSiparisAl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.NumericUpDown nmrIcecekAdedi;
        private System.Windows.Forms.NumericUpDown nmrPizzaAdedi;
        private System.Windows.Forms.ComboBox cmbIcecek;
        private System.Windows.Forms.ComboBox cmbPizzaBoyu;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbMusteriBilgileri;
    }
}

