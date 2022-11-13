namespace odev6
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
            this.calcbtn = new System.Windows.Forms.Button();
            this.number1txt = new System.Windows.Forms.TextBox();
            this.number2txt = new System.Windows.Forms.TextBox();
            this.number3txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resultlbl = new System.Windows.Forms.Label();
            this.result2lbl = new System.Windows.Forms.Label();
            this.root11lbl = new System.Windows.Forms.Label();
            this.root12lbl = new System.Windows.Forms.Label();
            this.root22lbl = new System.Windows.Forms.Label();
            this.root21lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calcbtn
            // 
            this.calcbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.calcbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calcbtn.Location = new System.Drawing.Point(236, 354);
            this.calcbtn.Name = "calcbtn";
            this.calcbtn.Size = new System.Drawing.Size(164, 45);
            this.calcbtn.TabIndex = 0;
            this.calcbtn.Text = "Calculate";
            this.calcbtn.UseVisualStyleBackColor = false;
            this.calcbtn.Click += new System.EventHandler(this.calcbtn_Click);
            // 
            // number1txt
            // 
            this.number1txt.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number1txt.Location = new System.Drawing.Point(332, 180);
            this.number1txt.Name = "number1txt";
            this.number1txt.Size = new System.Drawing.Size(114, 25);
            this.number1txt.TabIndex = 1;
            // 
            // number2txt
            // 
            this.number2txt.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number2txt.Location = new System.Drawing.Point(332, 230);
            this.number2txt.Name = "number2txt";
            this.number2txt.Size = new System.Drawing.Size(114, 25);
            this.number2txt.TabIndex = 1;
            // 
            // number3txt
            // 
            this.number3txt.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number3txt.Location = new System.Drawing.Point(332, 280);
            this.number3txt.Name = "number3txt";
            this.number3txt.Size = new System.Drawing.Size(114, 25);
            this.number3txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(166, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(166, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(166, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(154, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(501, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Calculating 2nd Degree root of Equation";
            // 
            // resultlbl
            // 
            this.resultlbl.AutoSize = true;
            this.resultlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resultlbl.Location = new System.Drawing.Point(492, 175);
            this.resultlbl.Name = "resultlbl";
            this.resultlbl.Size = new System.Drawing.Size(82, 25);
            this.resultlbl.TabIndex = 4;
            this.resultlbl.Text = "Result : ";
            this.resultlbl.Visible = false;
            // 
            // result2lbl
            // 
            this.result2lbl.AutoSize = true;
            this.result2lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.result2lbl.Location = new System.Drawing.Point(587, 176);
            this.result2lbl.Name = "result2lbl";
            this.result2lbl.Size = new System.Drawing.Size(54, 25);
            this.result2lbl.TabIndex = 5;
            this.result2lbl.Text = "------";
            this.result2lbl.Visible = false;
            // 
            // root11lbl
            // 
            this.root11lbl.AutoSize = true;
            this.root11lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.root11lbl.Location = new System.Drawing.Point(492, 227);
            this.root11lbl.Name = "root11lbl";
            this.root11lbl.Size = new System.Drawing.Size(79, 25);
            this.root11lbl.TabIndex = 6;
            this.root11lbl.Text = "Root 1 :";
            this.root11lbl.Visible = false;
            // 
            // root12lbl
            // 
            this.root12lbl.AutoSize = true;
            this.root12lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.root12lbl.Location = new System.Drawing.Point(587, 228);
            this.root12lbl.Name = "root12lbl";
            this.root12lbl.Size = new System.Drawing.Size(54, 25);
            this.root12lbl.TabIndex = 5;
            this.root12lbl.Text = "------";
            this.root12lbl.Visible = false;
            // 
            // root22lbl
            // 
            this.root22lbl.AutoSize = true;
            this.root22lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.root22lbl.Location = new System.Drawing.Point(587, 280);
            this.root22lbl.Name = "root22lbl";
            this.root22lbl.Size = new System.Drawing.Size(54, 25);
            this.root22lbl.TabIndex = 5;
            this.root22lbl.Text = "------";
            this.root22lbl.Visible = false;
            // 
            // root21lbl
            // 
            this.root21lbl.AutoSize = true;
            this.root21lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.root21lbl.Location = new System.Drawing.Point(492, 279);
            this.root21lbl.Name = "root21lbl";
            this.root21lbl.Size = new System.Drawing.Size(79, 25);
            this.root21lbl.TabIndex = 6;
            this.root21lbl.Text = "Root 2 :";
            this.root21lbl.Visible = false;
            this.root21lbl.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(846, 520);
            this.Controls.Add(this.root21lbl);
            this.Controls.Add(this.root22lbl);
            this.Controls.Add(this.root11lbl);
            this.Controls.Add(this.root12lbl);
            this.Controls.Add(this.result2lbl);
            this.Controls.Add(this.resultlbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.number3txt);
            this.Controls.Add(this.number2txt);
            this.Controls.Add(this.number1txt);
            this.Controls.Add(this.calcbtn);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2. Dereceden Denklem Kökü Hesaplama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcbtn;
        private System.Windows.Forms.TextBox number1txt;
        private System.Windows.Forms.TextBox number2txt;
        private System.Windows.Forms.TextBox number3txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label resultlbl;
        private System.Windows.Forms.Label result2lbl;
        private System.Windows.Forms.Label root11lbl;
        private System.Windows.Forms.Label root12lbl;
        private System.Windows.Forms.Label root22lbl;
        private System.Windows.Forms.Label root21lbl;
    }
}

