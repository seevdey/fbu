namespace odev14
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
            this.yontemcmbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hesaplabtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sayitxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sonuclbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yontemcmbx
            // 
            this.yontemcmbx.FormattingEnabled = true;
            this.yontemcmbx.Items.AddRange(new object[] {
            "For",
            "While"});
            this.yontemcmbx.Location = new System.Drawing.Point(292, 136);
            this.yontemcmbx.Name = "yontemcmbx";
            this.yontemcmbx.Size = new System.Drawing.Size(135, 24);
            this.yontemcmbx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(169, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yöntem : ";
            // 
            // hesaplabtn
            // 
            this.hesaplabtn.BackColor = System.Drawing.Color.Salmon;
            this.hesaplabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesaplabtn.Location = new System.Drawing.Point(240, 247);
            this.hesaplabtn.Name = "hesaplabtn";
            this.hesaplabtn.Size = new System.Drawing.Size(96, 46);
            this.hesaplabtn.TabIndex = 2;
            this.hesaplabtn.Text = "Hesapla";
            this.hesaplabtn.UseVisualStyleBackColor = false;
            this.hesaplabtn.Click += new System.EventHandler(this.hesaplabtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(199, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sayı : ";
            // 
            // sayitxt
            // 
            this.sayitxt.Location = new System.Drawing.Point(292, 82);
            this.sayitxt.Name = "sayitxt";
            this.sayitxt.Size = new System.Drawing.Size(135, 22);
            this.sayitxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(179, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sonuç : ";
            // 
            // sonuclbl
            // 
            this.sonuclbl.AutoSize = true;
            this.sonuclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonuclbl.Location = new System.Drawing.Point(288, 189);
            this.sonuclbl.Name = "sonuclbl";
            this.sonuclbl.Size = new System.Drawing.Size(64, 24);
            this.sonuclbl.TabIndex = 6;
            this.sonuclbl.Text = "---------";
            this.sonuclbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(616, 404);
            this.Controls.Add(this.sonuclbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sayitxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hesaplabtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yontemcmbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faktöriyel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox yontemcmbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hesaplabtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sayitxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sonuclbl;
    }
}

