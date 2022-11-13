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

        byte counter = 1;
        string username = "sevde";
        string password = "123";

        private void girisbtn_Click(object sender, EventArgs e)
        {
            /* Belirlenen kullanıcı adı ve şifre doğru girildiğinde “Giriş Başarılı”, yanlış girildiğinde “Girdiğiniz
               kullanıcı adı veya şifre hatalı” mesajı veren. 3 kere yanlış girildiğinde şifrenizi değiştirmek ister
               misiniz? diye sor ve şifreyi değiştir. 
            */
          
            if (counter > 2)
            {
                changelbl.Text = "Do you want to change a password?";
                yesbtn.Show();
                nobtn.Show();
            }
            else
            {
                string username1 = Convert.ToString(usernametxt.Text);
                string password1 = Convert.ToString(passwordtxt.Text);

                if (username == username1 && password == password1)
                {
                    MessageBox.Show("Login Successful");
                }
                else
                {
                    counter++;
                    MessageBox.Show("Username or Password is Wrong");
                    usernametxt.Clear();
                    passwordtxt.Clear();
                }
            }
        }

        private void yesbtn_Click(object sender, EventArgs e)
        {
            passwordtxt.Clear();
            passwordlbl.Text = "New password enter:";
            string password2 = Convert.ToString(passwordtxt.Text);
            password = password2;
            changebtn.Show();
        }

        private void nobtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void changebtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The password changed");
            Environment.Exit(0);
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        
    }
}
