namespace odev5
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
            this.girisbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.changelbl = new System.Windows.Forms.Label();
            this.yesbtn = new System.Windows.Forms.Button();
            this.nobtn = new System.Windows.Forms.Button();
            this.changebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // girisbtn
            // 
            this.girisbtn.BackColor = System.Drawing.Color.SlateBlue;
            this.girisbtn.Font = new System.Drawing.Font("Lucida Bright", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.girisbtn.Location = new System.Drawing.Point(337, 253);
            this.girisbtn.Name = "girisbtn";
            this.girisbtn.Size = new System.Drawing.Size(139, 48);
            this.girisbtn.TabIndex = 0;
            this.girisbtn.Text = "Login";
            this.girisbtn.UseVisualStyleBackColor = false;
            this.girisbtn.Click += new System.EventHandler(this.girisbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(206, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username : ";
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Font = new System.Drawing.Font("Lucida Bright", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordlbl.Location = new System.Drawing.Point(206, 181);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(145, 28);
            this.passwordlbl.TabIndex = 2;
            this.passwordlbl.Text = "Password : ";
            // 
            // usernametxt
            // 
            this.usernametxt.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernametxt.Location = new System.Drawing.Point(468, 125);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(139, 31);
            this.usernametxt.TabIndex = 3;
            this.usernametxt.TextChanged += new System.EventHandler(this.usernametxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Beige;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(341, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "LOGIN";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // passwordtxt
            // 
            this.passwordtxt.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordtxt.Location = new System.Drawing.Point(468, 178);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(139, 31);
            this.passwordtxt.TabIndex = 5;
            this.passwordtxt.UseSystemPasswordChar = true;
            // 
            // changelbl
            // 
            this.changelbl.AutoSize = true;
            this.changelbl.Font = new System.Drawing.Font("Lucida Bright", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.changelbl.Location = new System.Drawing.Point(27, 350);
            this.changelbl.Name = "changelbl";
            this.changelbl.Size = new System.Drawing.Size(92, 28);
            this.changelbl.TabIndex = 6;
            this.changelbl.Text = "----------";
            this.changelbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // yesbtn
            // 
            this.yesbtn.BackColor = System.Drawing.Color.LightCyan;
            this.yesbtn.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yesbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yesbtn.Location = new System.Drawing.Point(482, 343);
            this.yesbtn.Name = "yesbtn";
            this.yesbtn.Size = new System.Drawing.Size(45, 35);
            this.yesbtn.TabIndex = 7;
            this.yesbtn.Text = "Y";
            this.yesbtn.UseVisualStyleBackColor = false;
            this.yesbtn.Visible = false;
            this.yesbtn.Click += new System.EventHandler(this.yesbtn_Click);
            // 
            // nobtn
            // 
            this.nobtn.BackColor = System.Drawing.Color.LightCyan;
            this.nobtn.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nobtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nobtn.Location = new System.Drawing.Point(543, 343);
            this.nobtn.Name = "nobtn";
            this.nobtn.Size = new System.Drawing.Size(45, 35);
            this.nobtn.TabIndex = 8;
            this.nobtn.Text = "N";
            this.nobtn.UseVisualStyleBackColor = false;
            this.nobtn.Visible = false;
            this.nobtn.Click += new System.EventHandler(this.nobtn_Click);
            // 
            // changebtn
            // 
            this.changebtn.BackColor = System.Drawing.Color.SlateBlue;
            this.changebtn.Font = new System.Drawing.Font("Lucida Bright", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.changebtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.changebtn.Location = new System.Drawing.Point(337, 253);
            this.changebtn.Name = "changebtn";
            this.changebtn.Size = new System.Drawing.Size(139, 48);
            this.changebtn.TabIndex = 9;
            this.changebtn.Text = "Change";
            this.changebtn.UseVisualStyleBackColor = false;
            this.changebtn.Visible = false;
            this.changebtn.Click += new System.EventHandler(this.changebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(973, 541);
            this.Controls.Add(this.changebtn);
            this.Controls.Add(this.nobtn);
            this.Controls.Add(this.yesbtn);
            this.Controls.Add(this.changelbl);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.passwordlbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.girisbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button girisbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Label changelbl;
        private System.Windows.Forms.Button yesbtn;
        private System.Windows.Forms.Button nobtn;
        private System.Windows.Forms.Button changebtn;
    }
}

