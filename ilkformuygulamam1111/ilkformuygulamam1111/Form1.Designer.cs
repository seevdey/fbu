namespace ilkformuygulamam1111
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
            this.hesaplabtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sayi1txt = new System.Windows.Forms.TextBox();
            this.sayi2txt = new System.Windows.Forms.TextBox();
            this.islemtipcmbx = new System.Windows.Forms.ComboBox();
            this.sonuclbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(46, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "sayi1 : ";
            // 
            // hesaplabtn
            // 
            this.hesaplabtn.FlatAppearance.BorderSize = 3;
            this.hesaplabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hesaplabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.hesaplabtn.Location = new System.Drawing.Point(206, 275);
            this.hesaplabtn.Name = "hesaplabtn";
            this.hesaplabtn.Size = new System.Drawing.Size(121, 42);
            this.hesaplabtn.TabIndex = 1;
            this.hesaplabtn.Text = "Hesapla";
            this.hesaplabtn.UseVisualStyleBackColor = true;
            this.hesaplabtn.Click += new System.EventHandler(this.hesaplabtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(46, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "sayi2 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(8, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "İşlem Tipi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(55, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sonuç:";
            // 
            // sayi1txt
            // 
            this.sayi1txt.Location = new System.Drawing.Point(206, 46);
            this.sayi1txt.Name = "sayi1txt";
            this.sayi1txt.Size = new System.Drawing.Size(121, 23);
            this.sayi1txt.TabIndex = 4;
            this.sayi1txt.Leave += new System.EventHandler(this.sayi1txt_Leave);
            // 
            // sayi2txt
            // 
            this.sayi2txt.Location = new System.Drawing.Point(206, 97);
            this.sayi2txt.Name = "sayi2txt";
            this.sayi2txt.Size = new System.Drawing.Size(121, 23);
            this.sayi2txt.TabIndex = 5;
            this.sayi2txt.Leave += new System.EventHandler(this.sayi2txt_Leave);
            // 
            // islemtipcmbx
            // 
            this.islemtipcmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.islemtipcmbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.islemtipcmbx.FormattingEnabled = true;
            this.islemtipcmbx.Items.AddRange(new object[] {
            "Toplama",
            "Çıkarma",
            "Çarpma",
            "Bölme"});
            this.islemtipcmbx.Location = new System.Drawing.Point(206, 148);
            this.islemtipcmbx.Name = "islemtipcmbx";
            this.islemtipcmbx.Size = new System.Drawing.Size(121, 33);
            this.islemtipcmbx.TabIndex = 6;
            // 
            // sonuclbl
            // 
            this.sonuclbl.AutoSize = true;
            this.sonuclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonuclbl.Location = new System.Drawing.Point(200, 207);
            this.sonuclbl.Name = "sonuclbl";
            this.sonuclbl.Size = new System.Drawing.Size(160, 39);
            this.sonuclbl.TabIndex = 7;
            this.sonuclbl.Text = "-------------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(577, 364);
            this.Controls.Add(this.sonuclbl);
            this.Controls.Add(this.islemtipcmbx);
            this.Controls.Add(this.sayi2txt);
            this.Controls.Add(this.sayi1txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hesaplabtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.24F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Makinesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hesaplabtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sayi1txt;
        private System.Windows.Forms.TextBox sayi2txt;
        private System.Windows.Forms.Label sonuclbl;
        private System.Windows.Forms.ComboBox islemtipcmbx;
    }
}

