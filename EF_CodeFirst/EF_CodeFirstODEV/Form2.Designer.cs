
namespace EF_CodeFirstODEV
{
    partial class Form2
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
            this.lblSiparis = new System.Windows.Forms.Label();
            this.grpSiparis = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnDon = new System.Windows.Forms.Button();
            this.btnGor = new System.Windows.Forms.Button();
            this.cmbAdSoyad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSiparis.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSiparis
            // 
            this.lblSiparis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSiparis.Location = new System.Drawing.Point(20, 22);
            this.lblSiparis.Name = "lblSiparis";
            this.lblSiparis.Size = new System.Drawing.Size(373, 304);
            this.lblSiparis.TabIndex = 4;
            // 
            // grpSiparis
            // 
            this.grpSiparis.Controls.Add(this.lblSiparis);
            this.grpSiparis.Location = new System.Drawing.Point(12, 107);
            this.grpSiparis.Name = "grpSiparis";
            this.grpSiparis.Size = new System.Drawing.Size(414, 340);
            this.grpSiparis.TabIndex = 27;
            this.grpSiparis.TabStop = false;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(12, 61);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(153, 39);
            this.btnTemizle.TabIndex = 24;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnDon
            // 
            this.btnDon.Location = new System.Drawing.Point(32, 453);
            this.btnDon.Name = "btnDon";
            this.btnDon.Size = new System.Drawing.Size(373, 39);
            this.btnDon.TabIndex = 25;
            this.btnDon.Text = "SİPARİŞ EKRANINA GERİ DÖN";
            this.btnDon.UseVisualStyleBackColor = true;
            this.btnDon.Click += new System.EventHandler(this.btnDon_Click);
            // 
            // btnGor
            // 
            this.btnGor.Location = new System.Drawing.Point(184, 61);
            this.btnGor.Name = "btnGor";
            this.btnGor.Size = new System.Drawing.Size(242, 39);
            this.btnGor.TabIndex = 26;
            this.btnGor.Text = "KİŞİNİN SİPARİŞİNİ GÖR";
            this.btnGor.UseVisualStyleBackColor = true;
            this.btnGor.Click += new System.EventHandler(this.btnGor_Click);
            // 
            // cmbAdSoyad
            // 
            this.cmbAdSoyad.FormattingEnabled = true;
            this.cmbAdSoyad.Location = new System.Drawing.Point(200, 29);
            this.cmbAdSoyad.Name = "cmbAdSoyad";
            this.cmbAdSoyad.Size = new System.Drawing.Size(226, 21);
            this.cmbAdSoyad.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Sipariş Veren Kişiler :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 515);
            this.Controls.Add(this.grpSiparis);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnDon);
            this.Controls.Add(this.btnGor);
            this.Controls.Add(this.cmbAdSoyad);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grpSiparis.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSiparis;
        private System.Windows.Forms.GroupBox grpSiparis;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnDon;
        private System.Windows.Forms.Button btnGor;
        private System.Windows.Forms.ComboBox cmbAdSoyad;
        private System.Windows.Forms.Label label1;
    }
}