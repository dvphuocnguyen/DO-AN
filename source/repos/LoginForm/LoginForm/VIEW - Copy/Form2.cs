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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text ==textBox3.Text)
            {
                MessageBox.Show("Mat khau va mat khau nhap lai khong giong nhau");
                return;
            }
            if(BBLQL.Instance.checkeduser(textBox1.Text.Trim()))
            {
                MessageBox.Show("Tai khoan nay da ton tai");
                return;
            }            
            BBLQL.Instance.adduser(textBox1.Text,textBox2.Text);
            Form3 f = new Form3();
            this.Hide();
            f.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
            
        }

     
    }
}
