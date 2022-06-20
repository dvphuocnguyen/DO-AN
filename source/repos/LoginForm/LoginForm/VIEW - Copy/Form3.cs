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
    public partial class Form3 : Form
    {
        private string url;

        public Form3()
        {
            InitializeComponent();
            GUI();
            setCBB();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void GUI()
        {
            url = "C:/Users/LENOVO/Pictures/download.png";
            pictureBox2.Image= Image.FromFile("C:/Users/LENOVO/Pictures/download.png");   
        }
        private void setCBB()
        {
            comboBox1.Items.Add(new CBBuser
            {
                roleUser="Admin"
            });
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string i = DateTime.Now.ToString();
                    pictureBox2.Image = Image.FromFile(ofd.FileName);
                    url=ofd.FileName;
                    textBox1.Text = ofd.FileName;

                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {            
            BBLQL.Instance.adduser(textBox2.Text, textBox3.Text, textBox4.Text, radioButton1.Checked ? "Male" : "Female", textBox5.Text, dateTimePicker1.Value,((CBBuser)comboBox1.SelectedItem).roleUser,url);
        }
    }
}
