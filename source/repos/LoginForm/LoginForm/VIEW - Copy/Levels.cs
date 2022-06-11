using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Levels : Form
    {
        public Levels()
        {
            InitializeComponent();
            DisplayLevels();    
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-455C16V\SQLEXPRESS;Initial Catalog=Quizdb;Integrated Security=True");
        int Key = 0;
        private void Reset()
        {
            LvNameTb.Text = "";
            Key = 0;
        }
        private void DisplayLevels()
        {
            Con.Open();
            string Query = "select * from Levelsstbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            LvDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Levels_Load(object sender, EventArgs e)
        {

        }

        private void LvNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void LvSavebtn_Click(object sender, EventArgs e)
        {
            if (LvNameTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Levelsstbl (LvName) values (@LvN)", Con);
                    cmd.Parameters.AddWithValue("@LvN", LvNameTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Level saved");
                    Con.Close();
                    Reset();
                    DisplayLevels();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void LvReserbtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void LvEditbtn_Click(object sender, EventArgs e)
        {
            if (LvNameTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update Levelsstbl set LvName=@Lvn where LvId=@LvKey", Con);
                    cmd.Parameters.AddWithValue("@Lvn", LvNameTb.Text);
                    cmd.Parameters.AddWithValue("@LvKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Level updated");
                    Con.Close();
                    Reset();
                    DisplayLevels();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void LvDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LvNameTb.Text = LvDGV.SelectedRows[0].Cells[1].Value.ToString();
            if (LvNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(LvDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void LvQuestionLbl_Click(object sender, EventArgs e)
        {
            Questions obj = new Questions();
            obj.Show();
            this.Hide();
        }

        private void LvMembersLbl_Click(object sender, EventArgs e)
        {
            Members obj = new Members();
            obj.Show();
            this.Hide();
        }
    }
}
