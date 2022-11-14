namespace odev16
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
            this.ustxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabantxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sonuclbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hesaplabtn
            // 
            this.hesaplabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesaplabtn.Location = new System.Drawing.Point(173, 241);
            this.hesaplabtn.Name = "hesaplabtn";
            this.hesaplabtn.Size = new System.Drawing.Size(96, 42);
            this.hesaplabtn.TabIndex = 0;
            this.hesaplabtn.Text = "Hesapla";
            this.hesaplabtn.UseVisualStyleBackColor = true;
            this.hesaplabtn.Click += new System.EventHandler(this.hesaplabtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(141, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Üs : ";
            // 
            // ustxt
            // 
            this.ustxt.Location = new System.Drawing.Point(220, 86);
            this.ustxt.Name = "ustxt";
            this.ustxt.Size = new System.Drawing.Size(100, 20);
            this.ustxt.TabIndex = 2;
            this.ustxt.Leave += new System.EventHandler(this.ustxt_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(111, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Taban : ";
            // 
            // tabantxt
            // 
            this.tabantxt.Location = new System.Drawing.Point(220, 133);
            this.tabantxt.Name = "tabantxt";
            this.tabantxt.Size = new System.Drawing.Size(100, 20);
            this.tabantxt.TabIndex = 2;
            this.tabantxt.Leave += new System.EventHandler(this.tabantxt_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(111, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sonuç : ";
            // 
            // sonuclbl
            // 
            this.sonuclbl.AutoSize = true;
            this.sonuclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonuclbl.Location = new System.Drawing.Point(223, 180);
            this.sonuclbl.Name = "sonuclbl";
            this.sonuclbl.Size = new System.Drawing.Size(64, 22);
            this.sonuclbl.TabIndex = 4;
            this.sonuclbl.Text = "---------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(472, 365);
            this.Controls.Add(this.sonuclbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabantxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ustxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hesaplabtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üslü Sayı Hesaplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hesaplabtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ustxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tabantxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sonuclbl;
    }
}

