using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm11
{
    public partial class Form2 : Form
    {
        //2. YOL
        int _red, _green, _blue;
        private Color _renk;

        public Form2(int red, int green, int blue)
        {
            InitializeComponent();

            //2. YOL
            _red = red;
            _green = green;
            _blue = blue;
        }

        public Form2(Color renk)
        {
            InitializeComponent();
            this._renk = renk;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //2. YOL
            //this.BackColor = Color.FromArgb(_red, _green, _blue);

            //3. YOL
            this.BackColor = _renk;

        }
    }
}
