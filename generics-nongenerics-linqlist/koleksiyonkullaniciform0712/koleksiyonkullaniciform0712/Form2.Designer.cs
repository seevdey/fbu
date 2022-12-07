namespace koleksiyonkullaniciform0712
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.girişlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listelemeEkranlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriListelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girişlerToolStripMenuItem,
            this.listelemeEkranlarıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(737, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // girişlerToolStripMenuItem
            // 
            this.girişlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriGirişiToolStripMenuItem});
            this.girişlerToolStripMenuItem.Name = "girişlerToolStripMenuItem";
            this.girişlerToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.girişlerToolStripMenuItem.Text = "Girişler";
            // 
            // müşteriGirişiToolStripMenuItem
            // 
            this.müşteriGirişiToolStripMenuItem.Name = "müşteriGirişiToolStripMenuItem";
            this.müşteriGirişiToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.müşteriGirişiToolStripMenuItem.Text = "Müşteri Girişi";
            this.müşteriGirişiToolStripMenuItem.Click += new System.EventHandler(this.müşteriGirişiToolStripMenuItem_Click);
            // 
            // listelemeEkranlarıToolStripMenuItem
            // 
            this.listelemeEkranlarıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriListelemeToolStripMenuItem});
            this.listelemeEkranlarıToolStripMenuItem.Name = "listelemeEkranlarıToolStripMenuItem";
            this.listelemeEkranlarıToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.listelemeEkranlarıToolStripMenuItem.Text = "Listeleme Ekranları";
            // 
            // müşteriListelemeToolStripMenuItem
            // 
            this.müşteriListelemeToolStripMenuItem.Name = "müşteriListelemeToolStripMenuItem";
            this.müşteriListelemeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.müşteriListelemeToolStripMenuItem.Text = "Müşteri Listeleme";
            this.müşteriListelemeToolStripMenuItem.Click += new System.EventHandler(this.müşteriListelemeToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 421);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem girişlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriGirişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listelemeEkranlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriListelemeToolStripMenuItem;
    }
}