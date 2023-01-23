
namespace WinForm2
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
            this.txtUrunKodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.nuFiyati = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nuStok = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lstUrunListesi = new System.Windows.Forms.ListView();
            this.nuGaranti = new System.Windows.Forms.NumericUpDown();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.nuFiyati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuGaranti)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunKodu.Location = new System.Drawing.Point(404, 75);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(154, 26);
            this.txtUrunKodu.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(296, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Urun Kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(296, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Urun Adi";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAdi.Location = new System.Drawing.Point(404, 139);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(154, 26);
            this.txtUrunAdi.TabIndex = 4;
            // 
            // nuFiyati
            // 
            this.nuFiyati.DecimalPlaces = 2;
            this.nuFiyati.Location = new System.Drawing.Point(404, 215);
            this.nuFiyati.Name = "nuFiyati";
            this.nuFiyati.Size = new System.Drawing.Size(120, 22);
            this.nuFiyati.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(277, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Stok Miktari";
            // 
            // nuStok
            // 
            this.nuStok.Location = new System.Drawing.Point(404, 274);
            this.nuStok.Name = "nuStok";
            this.nuStok.Size = new System.Drawing.Size(120, 22);
            this.nuStok.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(329, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fiyat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(774, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Garanti Süresi";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(928, 79);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(776, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Üretim Tarihi";
            // 
            // lstUrunListesi
            // 
            this.lstUrunListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstUrunListesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstUrunListesi.GridLines = true;
            this.lstUrunListesi.HideSelection = false;
            this.lstUrunListesi.Location = new System.Drawing.Point(59, 340);
            this.lstUrunListesi.Name = "lstUrunListesi";
            this.lstUrunListesi.Size = new System.Drawing.Size(1202, 362);
            this.lstUrunListesi.TabIndex = 6;
            this.lstUrunListesi.UseCompatibleStateImageBehavior = false;
            this.lstUrunListesi.View = System.Windows.Forms.View.Details;
            // 
            // nuGaranti
            // 
            this.nuGaranti.Location = new System.Drawing.Point(928, 127);
            this.nuGaranti.Name = "nuGaranti";
            this.nuGaranti.Size = new System.Drawing.Size(120, 22);
            this.nuGaranti.TabIndex = 4;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(783, 191);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(146, 50);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(987, 191);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(163, 50);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnsil
            // 
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Location = new System.Drawing.Point(783, 260);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(358, 42);
            this.btnsil.TabIndex = 9;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Urun Kodu";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Urun Adi";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fiyati";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Stok Miktari";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Üretim Tarihi";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Garanti Süresi";
            this.columnHeader6.Width = 150;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 752);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lstUrunListesi);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.nuStok);
            this.Controls.Add(this.nuGaranti);
            this.Controls.Add(this.nuFiyati);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrunKodu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuFiyati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuGaranti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrunKodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.NumericUpDown nuFiyati;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nuStok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lstUrunListesi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.NumericUpDown nuGaranti;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}