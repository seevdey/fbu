namespace oop4form0112
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
            this.bilgiverbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.semttxt = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bilgiverbtn
            // 
            this.bilgiverbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgiverbtn.Location = new System.Drawing.Point(161, 123);
            this.bilgiverbtn.Name = "bilgiverbtn";
            this.bilgiverbtn.Size = new System.Drawing.Size(82, 37);
            this.bilgiverbtn.TabIndex = 0;
            this.bilgiverbtn.Text = "Bilgi Ver";
            this.bilgiverbtn.UseVisualStyleBackColor = true;
            this.bilgiverbtn.Click += new System.EventHandler(this.bilgiverbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(113, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Semt : ";
            // 
            // semttxt
            // 
            this.semttxt.Location = new System.Drawing.Point(191, 64);
            this.semttxt.Name = "semttxt";
            this.semttxt.Size = new System.Drawing.Size(100, 20);
            this.semttxt.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(69, 192);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(275, 160);
            this.listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 437);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.semttxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bilgiverbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daire Örneği";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bilgiverbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox semttxt;
        private System.Windows.Forms.ListBox listBox1;
    }
}

