namespace odev13
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
            this.parabirimicmbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dparabirimicmbx = new System.Windows.Forms.ComboBox();
            this.paratxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sonuclbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(220, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Girilen Para Birimi :";
            // 
            // parabirimicmbx
            // 
            this.parabirimicmbx.FormattingEnabled = true;
            this.parabirimicmbx.Items.AddRange(new object[] {
            "USD",
            "EURO",
            "STERLIN",
            "TL"});
            this.parabirimicmbx.Location = new System.Drawing.Point(435, 151);
            this.parabirimicmbx.Name = "parabirimicmbx";
            this.parabirimicmbx.Size = new System.Drawing.Size(121, 24);
            this.parabirimicmbx.TabIndex = 1;
            this.parabirimicmbx.SelectedIndexChanged += new System.EventHandler(this.parabirimicmbx_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(332, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Para :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(139, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dönüştürülecek Para Birimi :";
            // 
            // dparabirimicmbx
            // 
            this.dparabirimicmbx.FormattingEnabled = true;
            this.dparabirimicmbx.Items.AddRange(new object[] {
            "USD",
            "EURO",
            "STERLIN",
            "TL"});
            this.dparabirimicmbx.Location = new System.Drawing.Point(435, 197);
            this.dparabirimicmbx.Name = "dparabirimicmbx";
            this.dparabirimicmbx.Size = new System.Drawing.Size(121, 24);
            this.dparabirimicmbx.TabIndex = 1;
            // 
            // paratxt
            // 
            this.paratxt.Location = new System.Drawing.Point(435, 105);
            this.paratxt.Name = "paratxt";
            this.paratxt.Size = new System.Drawing.Size(121, 22);
            this.paratxt.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(435, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sonuclbl
            // 
            this.sonuclbl.AutoSize = true;
            this.sonuclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonuclbl.Location = new System.Drawing.Point(430, 249);
            this.sonuclbl.Name = "sonuclbl";
            this.sonuclbl.Size = new System.Drawing.Size(75, 25);
            this.sonuclbl.TabIndex = 6;
            this.sonuclbl.Text = "---------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(311, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sonuç : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sonuclbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.paratxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dparabirimicmbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.parabirimicmbx);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Para ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox parabirimicmbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox dparabirimicmbx;
        private System.Windows.Forms.TextBox paratxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label sonuclbl;
        private System.Windows.Forms.Label label4;
    }
}

