namespace oop6form0212
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
            this.kulladtxt = new System.Windows.Forms.TextBox();
            this.sifretxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uyeolbtn = new System.Windows.Forms.Button();
            this.yenigirislbl = new System.Windows.Forms.Label();
            this.evetbtn = new System.Windows.Forms.Button();
            this.hyrbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kulladtxt
            // 
            this.kulladtxt.Location = new System.Drawing.Point(241, 34);
            this.kulladtxt.Name = "kulladtxt";
            this.kulladtxt.Size = new System.Drawing.Size(100, 20);
            this.kulladtxt.TabIndex = 0;
            // 
            // sifretxt
            // 
            this.sifretxt.Location = new System.Drawing.Point(241, 73);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.Size = new System.Drawing.Size(100, 20);
            this.sifretxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(116, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(168, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre :";
            // 
            // uyeolbtn
            // 
            this.uyeolbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyeolbtn.Location = new System.Drawing.Point(199, 120);
            this.uyeolbtn.Name = "uyeolbtn";
            this.uyeolbtn.Size = new System.Drawing.Size(82, 38);
            this.uyeolbtn.TabIndex = 4;
            this.uyeolbtn.Text = "Üye Ol";
            this.uyeolbtn.UseVisualStyleBackColor = true;
            this.uyeolbtn.Click += new System.EventHandler(this.uyeolbtn_Click);
            // 
            // yenigirislbl
            // 
            this.yenigirislbl.AutoSize = true;
            this.yenigirislbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yenigirislbl.Location = new System.Drawing.Point(139, 258);
            this.yenigirislbl.Name = "yenigirislbl";
            this.yenigirislbl.Size = new System.Drawing.Size(247, 18);
            this.yenigirislbl.TabIndex = 7;
            this.yenigirislbl.Text = "Yeniden Giriş Yapmak İster Misiniz ?";
            this.yenigirislbl.Visible = false;
            // 
            // evetbtn
            // 
            this.evetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.evetbtn.Location = new System.Drawing.Point(186, 287);
            this.evetbtn.Name = "evetbtn";
            this.evetbtn.Size = new System.Drawing.Size(43, 36);
            this.evetbtn.TabIndex = 8;
            this.evetbtn.Text = "E";
            this.evetbtn.UseVisualStyleBackColor = true;
            this.evetbtn.Visible = false;
            // 
            // hyrbtn
            // 
            this.hyrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hyrbtn.Location = new System.Drawing.Point(251, 287);
            this.hyrbtn.Name = "hyrbtn";
            this.hyrbtn.Size = new System.Drawing.Size(43, 36);
            this.hyrbtn.TabIndex = 8;
            this.hyrbtn.Text = "H";
            this.hyrbtn.UseVisualStyleBackColor = true;
            this.hyrbtn.Visible = false;
            this.hyrbtn.Click += new System.EventHandler(this.hyrbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(186, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(510, 404);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hyrbtn);
            this.Controls.Add(this.evetbtn);
            this.Controls.Add(this.yenigirislbl);
            this.Controls.Add(this.uyeolbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sifretxt);
            this.Controls.Add(this.kulladtxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Olma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kulladtxt;
        private System.Windows.Forms.TextBox sifretxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uyeolbtn;
        private System.Windows.Forms.Label yenigirislbl;
        private System.Windows.Forms.Button evetbtn;
        private System.Windows.Forms.Button hyrbtn;
        private System.Windows.Forms.Label label3;
    }
}

