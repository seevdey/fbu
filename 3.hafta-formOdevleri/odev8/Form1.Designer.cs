namespace odev8
{
    partial class evetbtn
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
            this.tahminbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tahmintxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sonuclbl = new System.Windows.Forms.Label();
            this.metinlbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.hayirbtn = new System.Windows.Forms.Button();
            this.sonlbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tahminbtn
            // 
            this.tahminbtn.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tahminbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tahminbtn.Location = new System.Drawing.Point(406, 241);
            this.tahminbtn.Name = "tahminbtn";
            this.tahminbtn.Size = new System.Drawing.Size(128, 44);
            this.tahminbtn.TabIndex = 0;
            this.tahminbtn.Text = "Tahmin et";
            this.tahminbtn.UseVisualStyleBackColor = false;
            this.tahminbtn.Click += new System.EventHandler(this.tahminbtn_Click);
            this.tahminbtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tahminbtn_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(355, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sayı : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tahmintxt
            // 
            this.tahmintxt.Location = new System.Drawing.Point(464, 185);
            this.tahmintxt.Name = "tahmintxt";
            this.tahmintxt.Size = new System.Drawing.Size(136, 22);
            this.tahmintxt.TabIndex = 2;
            this.tahmintxt.TextChanged += new System.EventHandler(this.tahmintxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCyan;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(327, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "SAYI TAHMİN OYUNU";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // sonuclbl
            // 
            this.sonuclbl.AutoSize = true;
            this.sonuclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonuclbl.Location = new System.Drawing.Point(329, 309);
            this.sonuclbl.Name = "sonuclbl";
            this.sonuclbl.Size = new System.Drawing.Size(70, 24);
            this.sonuclbl.TabIndex = 4;
            this.sonuclbl.Text = "----------";
            this.sonuclbl.Visible = false;
            this.sonuclbl.Click += new System.EventHandler(this.sonuclbl_Click);
            // 
            // metinlbl
            // 
            this.metinlbl.AutoSize = true;
            this.metinlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.metinlbl.Location = new System.Drawing.Point(305, 420);
            this.metinlbl.Name = "metinlbl";
            this.metinlbl.Size = new System.Drawing.Size(321, 26);
            this.metinlbl.TabIndex = 5;
            this.metinlbl.Text = "Yeniden oynamak ister misiniz?";
            this.metinlbl.Visible = false;
            this.metinlbl.Click += new System.EventHandler(this.metinlbl_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkKhaki;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(402, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "E";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hayirbtn
            // 
            this.hayirbtn.BackColor = System.Drawing.Color.DarkKhaki;
            this.hayirbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hayirbtn.Location = new System.Drawing.Point(478, 470);
            this.hayirbtn.Name = "hayirbtn";
            this.hayirbtn.Size = new System.Drawing.Size(56, 38);
            this.hayirbtn.TabIndex = 7;
            this.hayirbtn.Text = "H";
            this.hayirbtn.UseVisualStyleBackColor = false;
            this.hayirbtn.Visible = false;
            this.hayirbtn.Click += new System.EventHandler(this.hayirbtn_Click);
            // 
            // sonlbl
            // 
            this.sonlbl.AutoSize = true;
            this.sonlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonlbl.ForeColor = System.Drawing.Color.Maroon;
            this.sonlbl.Location = new System.Drawing.Point(369, 361);
            this.sonlbl.Name = "sonlbl";
            this.sonlbl.Size = new System.Drawing.Size(70, 24);
            this.sonlbl.TabIndex = 8;
            this.sonlbl.Text = "----------";
            this.sonlbl.Visible = false;
            this.sonlbl.Click += new System.EventHandler(this.sonlbl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(235, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(450, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "1 ile 10 arasında tutulan sayıyı bulunuz";
            // 
            // evetbtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(979, 567);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sonlbl);
            this.Controls.Add(this.hayirbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metinlbl);
            this.Controls.Add(this.sonuclbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tahmintxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tahminbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "evetbtn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sayı Tahmin Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tahminbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tahmintxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sonuclbl;
        private System.Windows.Forms.Label metinlbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button hayirbtn;
        private System.Windows.Forms.Label sonlbl;
        private System.Windows.Forms.Label label3;
    }
}

