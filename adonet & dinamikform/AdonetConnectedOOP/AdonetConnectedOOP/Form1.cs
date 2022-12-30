using AdonetConnectedOOP.Sınıflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdonetConnectedOOP
{
    public partial class Form1 : Form
    {
        CRUD crud = new CRUD();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            create();
            read();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            update();
            read();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            delete();
            read();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        public void read()
        {
            dataGridView1.DataSource = null;
            crud.read_data();
            dataGridView1.DataSource = crud.dt;
        }

        public void create()
        {
            crud.customerID = textBox1.Text;
            crud.companyname = textBox2.Text;
            crud.contactname = textBox4.Text;
            crud.insert_data();
        }

        public void update()
        {
            crud.customerID = textBox1.Text;
            crud.companyname = textBox2.Text;
            crud.contactname = textBox4.Text;
            crud.update_data();
        }

        public void delete()
        {
            crud.customerID = textBox1.Text;
            crud.companyname = textBox2.Text;
            crud.contactname = textBox4.Text;
            crud.delete_data();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            crud.listeleme(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            crud.listeleme(this);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
