using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinemaAppWihtPdf
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Abdulhadi" && textBox2.Text == "123")
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                // افتح الفورم الرئيسي وأغلق فورم الدخول
                Form1 main = new Form1();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
