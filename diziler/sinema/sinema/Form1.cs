using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[,,] sinema = new string[3, 2, 4]; //3 kat, 2 salon, 4 koltuk var

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "X";
            textBox1.BackColor = Color.Red;
                              
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.BackColor = Color.Yellow;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "X";
            textBox2.BackColor = Color.Red;
        }

        private void textBox2_DoubleClick(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.BackColor = Color.Yellow;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "X";
            textBox3.BackColor = Color.Red;
        }

        private void textBox3_DoubleClick(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox3.BackColor = Color.Yellow;
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "X";
            textBox4.BackColor = Color.Red;
        }

        private void textBox4_DoubleClick(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox4.BackColor = Color.Yellow;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //alınmışsa koltuklar dolu, boşsa koltuklar boş olacak

            textBox1.Text = sinema[comboBox1.SelectedIndex, comboBox2.SelectedIndex, 0];
            textBox2.Text = sinema[comboBox1.SelectedIndex, comboBox2.SelectedIndex, 1];
            textBox3.Text = sinema[comboBox1.SelectedIndex, comboBox2.SelectedIndex, 2];
            textBox4.Text = sinema[comboBox1.SelectedIndex, comboBox2.SelectedIndex, 3];

            if (textBox1.Text == "X")
                textBox1.BackColor = Color.Red;
            else
                textBox1.BackColor = Color.Yellow;

            if (textBox2.Text == "X")
                textBox2.BackColor = Color.Red;
            else
                textBox2.BackColor = Color.Yellow;

            if (textBox3.Text == "X")
                textBox3.BackColor = Color.Red;
            else
                textBox3.BackColor = Color.Yellow;

            if (textBox4.Text == "X")
                textBox4.BackColor = Color.Red;
            else
                textBox4.BackColor = Color.Yellow;

            biletbtn.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //hiçbir şey seçili değilken koltuklar sarı gelecek

            if (comboBox1.SelectedIndex == -1)
            {
                textBox1.BackColor = Color.Yellow;
                textBox2.BackColor = Color.Yellow;
                textBox3.BackColor = Color.Yellow;
                textBox4.BackColor = Color.Yellow;
            }
        }

        private void biletbtn_Click(object sender, EventArgs e)
        {
            sinema[comboBox1.SelectedIndex, comboBox2.SelectedIndex, 0] = textBox1.Text;
            sinema[comboBox1.SelectedIndex, comboBox2.SelectedIndex, 1] = textBox2.Text;
            sinema[comboBox1.SelectedIndex, comboBox2.SelectedIndex, 2] = textBox3.Text;
            sinema[comboBox1.SelectedIndex, comboBox2.SelectedIndex, 3] = textBox4.Text;

            //comboBox1.ResetText();
            //comboBox2.ResetText();

            //comboBox1.SelectedIndex = -1;
            //comboBox2.SelectedIndex = -1;

            textBox1.BackColor = Color.Yellow;
            textBox2.BackColor = Color.Yellow;
            textBox3.BackColor = Color.Yellow;
            textBox4.BackColor = Color.Yellow;

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            biletbtn.Enabled = false;
            MessageBox.Show("Bilet alınmıştır");
        }

        string satir = "";
        string kat = ""; 
        string salon = "";

        private void listelebtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Kat" + "\t" + "Salon" + "\t" + "Koltuk1" + "\t" +"  Koltuk2" + "\t" + "Koltuk3" + "\t" + "Koltuk4" + "\t");
            listBox1.Items.Add("--------------------------------------------------------------------------------------------------------------");


            for (int i = 0; i < sinema.GetLength(0); i++)
            {
                for (int j = 0; j < sinema.GetLength(1); j++)
                {
                    for (int k = 0; k < sinema.GetLength(2); k++)
                    {
                        if (sinema[i, j, k] != "X")
                        {
                            sinema[i, j, k] = "B";
                        }

                        if (i == 0)
                            kat = "A";
                        else if (i == 1)
                            kat = "B";
                        else
                            kat = "C";
                           

                        //listBox1.Items.Add(sinema[i, j, k]);

                        int x = (j + 1);
                        salon = x.ToString();
                        satir += sinema[i, j, k] + "\t";


                        //listBox1.Items.Add(i + j + k);

                        //listBox1.Items.Add(sinema[i, j, k]);


                        //if (sinema[i, j, k] == "X")
                        //{
                        //    listBox1.Items.Add((i + 1).ToString());
                        //    listBox1.Items.Add((j + 1).ToString());
                        //}

                    }
                    listBox1.Items.Add(kat + "\t" + salon + "\t" + satir);
                    satir = "";
                }
                
            }

        }
    }
}
