﻿namespace odev1
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
            this.label2 = new System.Windows.Forms.Label();
            this.atxt = new System.Windows.Forms.TextBox();
            this.btxt = new System.Windows.Forms.TextBox();
            this.hesaplabtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sonuclbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(69, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "a sayisi:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(69, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "b sayisi:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // atxt
            // 
            this.atxt.Location = new System.Drawing.Point(202, 72);
            this.atxt.Name = "atxt";
            this.atxt.Size = new System.Drawing.Size(100, 22);
            this.atxt.TabIndex = 1;
            // 
            // btxt
            // 
            this.btxt.Location = new System.Drawing.Point(202, 136);
            this.btxt.Name = "btxt";
            this.btxt.Size = new System.Drawing.Size(100, 22);
            this.btxt.TabIndex = 2;
            this.btxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.btxt.Leave += new System.EventHandler(this.btxt_Leave);
            // 
            // hesaplabtn
            // 
            this.hesaplabtn.FlatAppearance.BorderSize = 4;
            this.hesaplabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hesaplabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesaplabtn.Location = new System.Drawing.Point(202, 271);
            this.hesaplabtn.Name = "hesaplabtn";
            this.hesaplabtn.Size = new System.Drawing.Size(100, 42);
            this.hesaplabtn.TabIndex = 3;
            this.hesaplabtn.Text = "Hesapla";
            this.hesaplabtn.UseVisualStyleBackColor = true;
            this.hesaplabtn.Click += new System.EventHandler(this.hesaplabtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(83, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sonuç:";
            // 
            // sonuclbl
            // 
            this.sonuclbl.AutoSize = true;
            this.sonuclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonuclbl.Location = new System.Drawing.Point(190, 199);
            this.sonuclbl.Name = "sonuclbl";
            this.sonuclbl.Size = new System.Drawing.Size(117, 29);
            this.sonuclbl.TabIndex = 5;
            this.sonuclbl.Text = "-------------";
            this.sonuclbl.Leave += new System.EventHandler(this.sonuclbl_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(628, 450);
            this.Controls.Add(this.sonuclbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hesaplabtn);
            this.Controls.Add(this.btxt);
            this.Controls.Add(this.atxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sayı Uygunluk Kontrolü";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox atxt;
        private System.Windows.Forms.TextBox btxt;
        private System.Windows.Forms.Button hesaplabtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sonuclbl;
    }
}

