namespace oop8formabstract0512
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
            this.listelebtn = new System.Windows.Forms.Button();
            this.adtxt = new System.Windows.Forms.TextBox();
            this.siniftxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.soyadlbl = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.branslbl = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.branstxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listelebtn
            // 
            this.listelebtn.BackColor = System.Drawing.Color.DarkSalmon;
            this.listelebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listelebtn.Location = new System.Drawing.Point(113, 175);
            this.listelebtn.Name = "listelebtn";
            this.listelebtn.Size = new System.Drawing.Size(78, 35);
            this.listelebtn.TabIndex = 0;
            this.listelebtn.Text = "Listele";
            this.listelebtn.UseVisualStyleBackColor = false;
            this.listelebtn.Click += new System.EventHandler(this.listelebtn_Click);
            // 
            // adtxt
            // 
            this.adtxt.Location = new System.Drawing.Point(128, 86);
            this.adtxt.Name = "adtxt";
            this.adtxt.Size = new System.Drawing.Size(100, 20);
            this.adtxt.TabIndex = 1;
            // 
            // siniftxt
            // 
            this.siniftxt.Location = new System.Drawing.Point(128, 124);
            this.siniftxt.Name = "siniftxt";
            this.siniftxt.Size = new System.Drawing.Size(100, 20);
            this.siniftxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(67, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad : ";
            // 
            // soyadlbl
            // 
            this.soyadlbl.AutoSize = true;
            this.soyadlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyadlbl.Location = new System.Drawing.Point(53, 123);
            this.soyadlbl.Name = "soyadlbl";
            this.soyadlbl.Size = new System.Drawing.Size(51, 18);
            this.soyadlbl.TabIndex = 4;
            this.soyadlbl.Text = "Sınıf :";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(70, 235);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(198, 160);
            this.listBox1.TabIndex = 5;
            // 
            // branslbl
            // 
            this.branslbl.AutoSize = true;
            this.branslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.branslbl.Location = new System.Drawing.Point(42, 124);
            this.branslbl.Name = "branslbl";
            this.branslbl.Size = new System.Drawing.Size(62, 18);
            this.branslbl.TabIndex = 6;
            this.branslbl.Text = "Branş :";
            this.branslbl.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.RosyBrown;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.Location = new System.Drawing.Point(59, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 21);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Öğrenci";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.RosyBrown;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2.Location = new System.Drawing.Point(172, 32);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(97, 21);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.Text = "Öğretmen";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // branstxt
            // 
            this.branstxt.Location = new System.Drawing.Point(128, 124);
            this.branstxt.Name = "branstxt";
            this.branstxt.Size = new System.Drawing.Size(100, 20);
            this.branstxt.TabIndex = 9;
            this.branstxt.Visible = false;
            this.branstxt.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(346, 457);
            this.Controls.Add(this.branstxt);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.branslbl);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.soyadlbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siniftxt);
            this.Controls.Add(this.adtxt);
            this.Controls.Add(this.listelebtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abstract ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button listelebtn;
        private System.Windows.Forms.TextBox adtxt;
        private System.Windows.Forms.TextBox siniftxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label soyadlbl;
        private System.Windows.Forms.Label branslbl;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox branstxt;
        public System.Windows.Forms.ListBox listBox1;
    }
}

