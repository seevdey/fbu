
using oopeventform.Sınıflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oopeventform
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        


        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int txt1 = int.Parse(textBox1.Text); 
            int txt2 = int.Parse(textBox2.Text); 
            Operations op = new Operations(txt1, txt2);
            listBox1.Items.Add("Toplama işlem sonucu: "+op.AddOperations().ToString());
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int txt1 = int.Parse(textBox1.Text);
            int txt2 = int.Parse(textBox2.Text);
            Operations op2 = new Operations(txt1, txt2);
            listBox1.Items.Add("Çıkarma işlemi sonucu: " + op2.SubOperations().ToString());
        }
    }


    //class Maths
    //{
    //    public delegate void SampleDelegate();
    //    public event SampleDelegate SampleEvent;

    //    public int Add(int a, int b)
    //    {
    //        if (SampleEvent != null)
    //        {
    //            SampleEvent();
    //            return a + b;
    //        }
    //        else
    //            MessageBox.Show("Olay çağırılamadı");
    //            return 0;
    //    }

    //    public int Substract(int x, int y)
    //    {
    //        if (SampleEvent != null)
    //        {
    //            SampleEvent();
    //            if (x > y)
    //            {
    //                return x - y;
    //            }
    //            else
    //                return y - x;
    //        }
    //        else
    //        {
    //            MessageBox.Show("Olay çağırılamadı");
    //            return 0;
    //        }
    //    }
    //}

    //class Operations
    //{
    //    Maths m;
    //    public int a { get; set; }
    //    public int b { get; set; }

    //    public Operations(int x, int y)//const başlangıç metodu
    //    {
    //        //bu kodu class içinde değil metod içinde yazarsın yani class ta işlem olmaz. metodda olur

    //        m = new Maths(); //m hafızada bir nesne olmuş oluyor
    //        m.SampleEvent += SampleEventHandler; //m nin event ı  çağrıldığında SampleEventHandler() bu kısım çağırılacak
    //        a = x; //a sınıfın özelliği
    //        b = y;
    //    }

    //    public void SampleEventHandler()
    //    {
    //        MessageBox.Show("SampleEventHandler çağırıldı");
    //    }

    //    public int AddOperations()
    //    {
    //        return m.Add(a, b);
    //    }

    //    public int SubOperations()
    //    {
    //        return m.Substract(a, b);
    //    }
    //}
}
