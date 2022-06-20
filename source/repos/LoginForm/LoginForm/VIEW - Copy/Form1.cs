using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginForm.BBL;
using LoginForm.DTO;
namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if(BBLQL.Instance.checkuser(txtUserName.Text,txtPassword.Text))
            {
                Form3 f = new Form3();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("The Username or Password you entered is incorrect, try again", "Warning!");
                txtUserName.Text="";
                txtPassword.Text="";
                txtUserName.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
