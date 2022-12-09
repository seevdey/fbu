namespace _0812
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void DisplayMeasurements(int a, int b)
        {
            switch ((a,b)) // i�ine 2 tane de�i�ken koyabiliyoruz
            {
                case ( > 0, > 0) when a == b: //a ve b s�f�rdan b�y�k olacak a ve be birbirine e�itse bu case �al��acak
                    MessageBox.Show($"Both measurements are valid and equal to {a}.");
                    break;
                case ( > 0, > 0): //ikisi s�f�rdan b�y�k olursa
                    MessageBox.Show($"First measurement is {a}, second measurement {b}.");
                    break;
                default:
                    MessageBox.Show("One or both measurements are not valid");
                    break;
            }
        }

        void notlar(int not)
        {
            switch (not) // i�ine 2 tane de�i�ken koyabiliyoruz
            {
                case ( > 0 and <45): 
                    MessageBox.Show("F");
                    break;
                case ( > 45 and < 55):
                    MessageBox.Show("D");
                    break;
                case (>= 55 and <= 70): 
                    MessageBox.Show("C");
                    break;
                case (> 70 and <= 85):
                    MessageBox.Show("B");
                    break;
                case (>=85 and <= 100):
                    MessageBox.Show("A");
                    break;
                default:
                    MessageBox.Show("Ge�ersiz Not");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayMeasurements(3, 4);
            DisplayMeasurements(5, 5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            notlar(int.Parse(textBox1.Text));
        }
    }
}