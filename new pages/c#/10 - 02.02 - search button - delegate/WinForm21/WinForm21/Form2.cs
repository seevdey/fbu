using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm21
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        DataTable dt;
        private void Form2_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Adi", typeof(string));
            dt.Columns.Add("Soyadi", typeof(string));
            dt.Columns.Add("Tarih", typeof(DateTime));

            dt.Rows.Add(1, "Isil", "Ozturk", DateTime.Now);
            dt.Rows.Add(2, "Cansu", "Koç", DateTime.Now);
            dt.Rows.Add(3, "Hatice", "Gunay", DateTime.Now);
            dt.Rows.Add(4, "Sabri", "Sarioglu", DateTime.Now);

            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataRow item in dt.Rows)
            {
                //listBox1.Items.Add(item.Cells["Adi"].Value.ToString());
                listBox1.Items.Add(string.Format("{0} -- {1} -- {2} -- {3}", item[0], item[1], item[2], item[3]));
            }
            listBox1.Items.Add("============================");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //listBox1.Items.Add(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //listBox1.Items.Add(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            //listBox1.Items.Add(dataGridView1.CurrentRow.Cells[2].Value.ToString());


            //ilgili row u yakaladık
            //ilgili rowdaki cell i yakaladık
            //Cell den ilgili kolon indexi yakaladın
            //sonunda değeri almış oldu (value)
            //string data = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(); //neye tıklarsan onu yakalar
            //listBox1.Items.Add(data);

            //string dataX = dataGridView1.SelectedCells[0].Value.ToString(); //neye tıklarsan onu yakalar
            //listBox1.Items.Add(dataX);

            string dataX2 = dataGridView1.CurrentRow.Cells[0].Value.ToString(); //ilgili satırın id sini yazdırır
            listBox1.Items.Add(dataX2);

            //seçili satırın tümünü listbox a yazdırır
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                listBox1.Items.Add(row.Cells[0].Value.ToString() + "  " + row.Cells[1].Value.ToString() + "  " + row.Cells[2].Value.ToString());
            }


            //seçili satırun tümünü listbox a yazdırır
            List<string> selectedRows = new List<string>();

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string currentRow = string.Empty;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    currentRow += String.Format("{0} ", cell.FormattedValue);
                }

                selectedRows.Add(currentRow);
            }

            for (int i = 0; i < selectedRows.Count; i++)
            {
                this.listBox1.Items.Add(selectedRows[i]);
            }
        }
    }
}
