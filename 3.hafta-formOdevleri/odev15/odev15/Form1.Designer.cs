namespace odev15
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
            this.hesaplabtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.urun1txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.urun2txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sonuclbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hesaplabtn
            // 
            this.hesaplabtn.BackColor = System.Drawing.Color.LightGray;
            this.hesaplabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesaplabtn.Location = new System.Drawing.Point(192, 215);
            this.hesaplabtn.Name = "hesaplabtn";
            this.hesaplabtn.Size = new System.Drawing.Size(98, 45);
            this.hesaplabtn.TabIndex = 0;
            this.hesaplabtn.Text = "Hesapla";
            this.hesaplabtn.UseVisualStyleBackColor = false;
            this.hesaplabtn.Click += new System.EventHandler(this.hesaplabtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(94, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. Ürün Fiyatı : ";
            // 
            // urun1txt
            // 
            this.urun1txt.Location = new System.Drawing.Point(260, 69);
            this.urun1txt.Name = "urun1txt";
            this.urun1txt.Size = new System.Drawing.Size(100, 20);
            this.urun1txt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(94, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "2. Ürün Fiyatı : ";
            // 
            // urun2txt
            // 
            this.urun2txt.Location = new System.Drawing.Point(260, 112);
            this.urun2txt.Name = "urun2txt";
            this.urun2txt.Size = new System.Drawing.Size(100, 20);
            this.urun2txt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(73, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ödenecek Tutar : ";
            // 
            // sonuclbl
            // 
            this.sonuclbl.AutoSize = true;
            this.sonuclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonuclbl.Location = new System.Drawing.Point(256, 159);
            this.sonuclbl.Name = "sonuclbl";
            this.sonuclbl.Size = new System.Drawing.Size(75, 20);
            this.sonuclbl.TabIndex = 1;
            this.sonuclbl.Text = "-----------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(464, 318);
            this.Controls.Add(this.urun2txt);
            this.Controls.Add(this.sonuclbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.urun1txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hesaplabtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutar HEsaplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hesaplabtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox urun1txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox urun2txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sonuclbl;
    }
}

