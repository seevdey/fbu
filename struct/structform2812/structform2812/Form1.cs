using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace structform2812
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Nesne")
            {
                //Nesne oluşturduk
                string txt1 = textBox2.Text; //yer
                int txt2 = int.Parse(textBox3.Text); //yaş
                User u = new User(txt1, txt2);
                listBox1.Items.Add("Name : " + User.name + " Location : " + u.location + "Age : " + u.age);
            }
            else if (comboBox1.Text == "Yapı")
            {
                //Yapı kullandık
                User u1; //sadece struct ı kullandım
                string txt3 = textBox2.Text;
                int txt4 = int.Parse(textBox3.Text);
                u1.location = txt3;
                u1.age = txt4;
                listBox1.Items.Add("Name : " + User.name + " Location : " + u1.location +   "Age : " + u1.age);
            }
        }
    }

    struct User
    {
        public const  string name = "serdar beyazkaya";
        public string location;
        public int age;

        public User(string a, int b)
        {
            location = a;
            age = b;
        }
    }
}
