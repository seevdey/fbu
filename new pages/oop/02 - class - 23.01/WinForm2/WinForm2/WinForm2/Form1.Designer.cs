
namespace WinForm2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTuru = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYayinEvi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lstKitaplar = new System.Windows.Forms.ListBox();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(53, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı:";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapAdi.Location = new System.Drawing.Point(57, 69);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(154, 26);
            this.txtKitapAdi.TabIndex = 1;
            // 
            // txtYazar
            // 
            this.txtYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYazar.Location = new System.Drawing.Point(58, 144);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(154, 26);
            this.txtYazar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(54, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yazar:";
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtISBN.Location = new System.Drawing.Point(58, 229);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(154, 26);
            this.txtISBN.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(58, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Türü:";
            // 
            // txtTuru
            // 
            this.txtTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTuru.Location = new System.Drawing.Point(58, 312);
            this.txtTuru.Name = "txtTuru";
            this.txtTuru.Size = new System.Drawing.Size(154, 26);
            this.txtTuru.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(58, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "ISBN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(58, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Yayın Evi:";
            // 
            // txtYayinEvi
            // 
            this.txtYayinEvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYayinEvi.Location = new System.Drawing.Point(58, 391);
            this.txtYayinEvi.Name = "txtYayinEvi";
            this.txtYayinEvi.Size = new System.Drawing.Size(154, 26);
            this.txtYayinEvi.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(58, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Yayın Tarihi:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker.Location = new System.Drawing.Point(58, 470);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(251, 26);
            this.dateTimePicker.TabIndex = 11;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown.Location = new System.Drawing.Point(62, 548);
            this.numericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(72, 26);
            this.numericUpDown.TabIndex = 12;
            // 
            // btnEkle
            // 
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(17, 599);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(94, 40);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(58, 513);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Sayfa Sayısı:";
            // 
            // lstKitaplar
            // 
            this.lstKitaplar.FormattingEnabled = true;
            this.lstKitaplar.ItemHeight = 16;
            this.lstKitaplar.Location = new System.Drawing.Point(456, 36);
            this.lstKitaplar.Name = "lstKitaplar";
            this.lstKitaplar.Size = new System.Drawing.Size(427, 644);
            this.lstKitaplar.TabIndex = 15;
            this.lstKitaplar.DoubleClick += new System.EventHandler(this.lstKitaplar_DoubleClick);
            // 
            // btnguncelle
            // 
            this.btnguncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.Location = new System.Drawing.Point(136, 599);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(140, 40);
            this.btnguncelle.TabIndex = 16;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Location = new System.Drawing.Point(302, 599);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(122, 40);
            this.btnsil.TabIndex = 17;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 741);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.lstKitaplar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtYayinEvi);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTuru);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTuru;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYayinEvi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstKitaplar;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnsil;
    }
}

