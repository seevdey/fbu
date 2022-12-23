using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdonetConnectDinamik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TextBox tt1 = new TextBox();
        TextBox tt2 = new TextBox();
        TextBox tt3 = new TextBox();
        Label l1 = new Label();
        Label l2 = new Label();
        Button button1 = new Button();
        Button button2 = new Button();
        Button button3 = new Button();
        Button button4 = new Button();
        Button button5 = new Button();
        DataGrid dataGridView1 = new DataGrid();
        StatusStrip statusStrip1 = new StatusStrip();

        private void Form1_Load(object sender, EventArgs e)
        {
            // 
            // label1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l1.Location = new System.Drawing.Point(160, 54);
            this.l1.Name = "label1";
            this.l1.Size = new System.Drawing.Size(40, 17);
            this.l1.TabIndex = 0;
            this.l1.Text = "Adı : ";
            Controls.Add(this.l1);
            // 
            // label2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l2.Location = new System.Drawing.Point(137, 100);
            this.l2.Name = "label2";
            this.l2.Size = new System.Drawing.Size(63, 17);
            this.l2.TabIndex = 0;
            this.l2.Text = "Soyadı : ";
            Controls.Add(this.l2);
            // 
            // textBox1
            // 
            this.tt1.Location = new System.Drawing.Point(217, 53);
            this.tt1.Name = "textBox1";
            this.tt1.Size = new System.Drawing.Size(100, 20);
            this.tt1.TabIndex = 1;
            Controls.Add(this.tt1);
            // 
            // textBox2
            // 
            this.tt2.Location = new System.Drawing.Point(217, 100);
            this.tt2.Name = "textBox2";
            this.tt2.Size = new System.Drawing.Size(100, 20);
            this.tt2.TabIndex = 2;
            Controls.Add(this.tt2);
            // 
            // textBox3
            // 
            this.tt3.Location = new System.Drawing.Point(413, 54);
            this.tt3.Name = "textBox3";
            this.tt3.Size = new System.Drawing.Size(29, 20);
            this.tt3.TabIndex = 3;
            Controls.Add(this.tt3);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(130, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            Controls.Add(button1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(228, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(333, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 40);
            this.button3.TabIndex = 6;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(438, 155);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 40);
            this.button4.TabIndex = 7;
            this.button4.Text = "Tüm Liste";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            //this.dataGridView1.Location = new System.Drawing.Point(131, 236);
            //this.dataGridView1.Name = "dataGridView1";
            //this.dataGridView1.Size = new System.Drawing.Size(389, 270);
            //this.dataGridView1.TabIndex = 8;
            //this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
          
            //// 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(333, 49);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(52, 28);
            this.button5.TabIndex = 10;
            this.button5.Text = "Ara";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            //this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            //this.toolStripStatusLabel1});
            //this.statusStrip1.Location = new System.Drawing.Point(0, 580);
            //this.statusStrip1.Name = "statusStrip1";
            //this.statusStrip1.Size = new System.Drawing.Size(673, 22);
            //this.statusStrip1.TabIndex = 11;
            //this.statusStrip1.Text = "statusStrip1";
            
        }


        private void mesaj(object sender, EventArgs e)
        {
            MessageBox.Show("Bu sınıf başarır mı ?");
        }

        private void ekle(object sender, EventArgs e)
        {

            //dinamik bir textbox tasarlamış olduk
            tt1.Text = "";
        }

        private void ekle2(object sender, EventArgs e)
        {

            //dinamik bir textbox tasarlamış olduk
            tt2.Text = "";
        }
    }
}
