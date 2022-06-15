using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginForm.DTO;
using LoginForm.BBL;
namespace LoginForm
{
    public partial class Form4 : Form
    {
        
        public Form4()
        {
            InitializeComponent();
           // LoadData();
            
        }
     
   
        public void  LoadData()
        {
            QLENG db = new QLENG();
            dataGridView1.DataSource = db.ImageDoanHinhs.ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
       
            using (OpenFileDialog ofd = new OpenFileDialog() {Filter= "Image files (*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*", Multiselect=false })
            {
                if(ofd.ShowDialog()==DialogResult.OK)
                {
                    string i = DateTime.Now.ToString();
                    BBLQL.Instance.addhinhanh(i, ofd.FileName, textBox2.Text);
                    LoadData();
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    textBox1.Text = ofd.FileName;
                   
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QLENG db = new QLENG();
            List<ImageDoanHinh> listhinh = new List<ImageDoanHinh>();
            if (dataGridView1.SelectedRows.Count>0)
            {
                foreach(DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    BBLQL.Instance.deletehinhanh(i.Cells["id"].Value.ToString());                    
                }
                LoadData();              
                
            }
        }
    }
}
