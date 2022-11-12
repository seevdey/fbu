using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void girisbtn_Click(object sender, EventArgs e)
        {
            /* Belirlenen kullanıcı adı ve şifre doğru girildiğinde “Giriş Başarılı”, yanlış girildiğinde “Girdiğiniz
               kullanıcı adı veya şifre hatalı” mesajı veren. 3 kere yanlış girildiğinde şifrenizi değiştirmek ister
               misiniz? diye sor ve şifreyi değiştir. 
            */

            string username = "sevde";
            string password = "123";
            byte counter = 0;

            if (counter >= 3)
            {
            }
            else
            {
                string username1 = Convert.ToString(usernametxt.Text);
                string password1 = Convert.ToString(passwordtxt.Text);
                counter++;

                if (username == username1 && password == password1)
                {
                    MessageBox.Show("Login Successful");
                }
                else
                {
                    MessageBox.Show("Username or Password is Wrong");
                    usernametxt.Clear();
                    passwordtxt.Clear();
                }
            }

        }

        private void yesbtn_Click(object sender, EventArgs e)
        {
           
        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
