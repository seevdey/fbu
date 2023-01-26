
namespace WinForm13
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
            this.btnBmw = new System.Windows.Forms.Button();
            this.btnTesla = new System.Windows.Forms.Button();
            this.btnTofas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBmw
            // 
            this.btnBmw.Location = new System.Drawing.Point(133, 129);
            this.btnBmw.Name = "btnBmw";
            this.btnBmw.Size = new System.Drawing.Size(85, 51);
            this.btnBmw.TabIndex = 0;
            this.btnBmw.Text = "BMW";
            this.btnBmw.UseVisualStyleBackColor = true;
            this.btnBmw.Click += new System.EventHandler(this.btnBmw_Click);
            // 
            // btnTesla
            // 
            this.btnTesla.Location = new System.Drawing.Point(236, 129);
            this.btnTesla.Name = "btnTesla";
            this.btnTesla.Size = new System.Drawing.Size(85, 51);
            this.btnTesla.TabIndex = 0;
            this.btnTesla.Text = "TESLA";
            this.btnTesla.UseVisualStyleBackColor = true;
            this.btnTesla.Click += new System.EventHandler(this.btnTesla_Click);
            // 
            // btnTofas
            // 
            this.btnTofas.Location = new System.Drawing.Point(348, 129);
            this.btnTofas.Name = "btnTofas";
            this.btnTofas.Size = new System.Drawing.Size(85, 51);
            this.btnTofas.TabIndex = 0;
            this.btnTofas.Text = "TOFAŞ";
            this.btnTofas.UseVisualStyleBackColor = true;
            this.btnTofas.Click += new System.EventHandler(this.btnTofas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTofas);
            this.Controls.Add(this.btnTesla);
            this.Controls.Add(this.btnBmw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBmw;
        private System.Windows.Forms.Button btnTesla;
        private System.Windows.Forms.Button btnTofas;
    }
}

