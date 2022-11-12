namespace odev3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kenar1txt = new System.Windows.Forms.TextBox();
            this.kenar2txt = new System.Windows.Forms.TextBox();
            this.kenar3txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sonuclbl = new System.Windows.Forms.Label();
            this.sifirlabtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hesaplabtn
            // 
            this.hesaplabtn.BackColor = System.Drawing.Color.Goldenrod;
            this.hesaplabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesaplabtn.Location = new System.Drawing.Point(345, 365);
            this.hesaplabtn.Name = "hesaplabtn";
            this.hesaplabtn.Size = new System.Drawing.Size(124, 52);
            this.hesaplabtn.TabIndex = 0;
            this.hesaplabtn.Text = "Hesapla";
            this.hesaplabtn.UseVisualStyleBackColor = false;
            this.hesaplabtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(209, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "ÜÇGEN ÇEŞİTİ BULMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(257, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "1. kenar : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(257, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "2. kenar : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(257, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "3. kenar : ";
            // 
            // kenar1txt
            // 
            this.kenar1txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kenar1txt.Location = new System.Drawing.Point(401, 113);
            this.kenar1txt.Name = "kenar1txt";
            this.kenar1txt.Size = new System.Drawing.Size(137, 26);
            this.kenar1txt.TabIndex = 5;
            // 
            // kenar2txt
            // 
            this.kenar2txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kenar2txt.Location = new System.Drawing.Point(401, 176);
            this.kenar2txt.Name = "kenar2txt";
            this.kenar2txt.Size = new System.Drawing.Size(137, 26);
            this.kenar2txt.TabIndex = 6;
            // 
            // kenar3txt
            // 
            this.kenar3txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kenar3txt.Location = new System.Drawing.Point(401, 239);
            this.kenar3txt.Name = "kenar3txt";
            this.kenar3txt.Size = new System.Drawing.Size(137, 26);
            this.kenar3txt.TabIndex = 7;
            this.kenar3txt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(257, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "SONUÇ :";
            // 
            // sonuclbl
            // 
            this.sonuclbl.AutoSize = true;
            this.sonuclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonuclbl.Location = new System.Drawing.Point(396, 302);
            this.sonuclbl.Name = "sonuclbl";
            this.sonuclbl.Size = new System.Drawing.Size(149, 29);
            this.sonuclbl.TabIndex = 9;
            this.sonuclbl.Text = "-----------------";
            // 
            // sifirlabtn
            // 
            this.sifirlabtn.BackColor = System.Drawing.Color.Chocolate;
            this.sifirlabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifirlabtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sifirlabtn.Location = new System.Drawing.Point(360, 440);
            this.sifirlabtn.Name = "sifirlabtn";
            this.sifirlabtn.Size = new System.Drawing.Size(97, 34);
            this.sifirlabtn.TabIndex = 10;
            this.sifirlabtn.Text = "Sıfırla";
            this.sifirlabtn.UseVisualStyleBackColor = false;
            this.sifirlabtn.Click += new System.EventHandler(this.sifirlabtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(868, 527);
            this.Controls.Add(this.sifirlabtn);
            this.Controls.Add(this.sonuclbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kenar3txt);
            this.Controls.Add(this.kenar2txt);
            this.Controls.Add(this.kenar1txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hesaplabtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üçgen Çeşiti Bulma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hesaplabtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kenar1txt;
        private System.Windows.Forms.TextBox kenar2txt;
        private System.Windows.Forms.TextBox kenar3txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sonuclbl;
        private System.Windows.Forms.Button sifirlabtn;
    }
}

