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
    public partial class Members : Form
    {
        public Members()
        {
            InitializeComponent();
            DisplayMembers();   
        }

        private void Reset()
        {
            MbNameTb.Text = "";
            MbAgeTb.Text = "";
            MbPhoneTb.Text = "";
            MbAddressTb.Text = "";
            MbPasswordTb.Text = "";

        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-455C16V\SQLEXPRESS;Initial Catalog=Quizdb;Integrated Security=True");
        private void DisplayMembers()
        {
            Con.Open();
            string Query = "select * from Memberstbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            MembersDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (MbNameTb.Text == "" || MbAgeTb.Text == "" || MbPasswordTb.Text == "" || MbAddressTb.Text == "" || MbPhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    int score = 0;
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Memberstbl (MName,MAge,MPass,MScore,MPhone,Madd) values (@Mn,@Ma,@Mp,@Ms,@Mph,@Mad)", Con);
                    cmd.Parameters.AddWithValue("@Mn", MbNameTb.Text);
                    cmd.Parameters.AddWithValue("@Ma", MbAgeTb.Text);
                    cmd.Parameters.AddWithValue("@Mp", MbPasswordTb.Text);
                    cmd.Parameters.AddWithValue("@Ms", score);
                    cmd.Parameters.AddWithValue("@Mph", MbPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@Mad", MbAddressTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member saved");
                    Con.Close();
                    Reset();
                    DisplayMembers();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();    
        }
        int Key = 0;
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (MbNameTb.Text == "" || MbAgeTb.Text == "" || MbPasswordTb.Text == "" || MbAddressTb.Text == "" || MbPhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update Memberstbl set MName=@Mn,MAge=@Ma,MPass=@Mp,MAdd=@Mad,MPhone=@Mph where MemId=@MKey", Con);
                    cmd.Parameters.AddWithValue("@Mn", MbNameTb.Text);
                    cmd.Parameters.AddWithValue("@Ma", MbAgeTb.Text);
                    cmd.Parameters.AddWithValue("@Mp", MbPasswordTb.Text);
                    cmd.Parameters.AddWithValue("@Mph", MbPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@Mad", MbAddressTb.Text);
                    cmd.Parameters.AddWithValue("@MKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member updated");
                    Con.Close();
                    Reset();
                    DisplayMembers();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void MembersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MbNameTb.Text = MembersDGV.SelectedRows[0].Cells[1].Value.ToString();
            MbAgeTb.Text = MembersDGV.SelectedRows[0].Cells[2].Value.ToString();
            MbPasswordTb.Text = MembersDGV.SelectedRows[0].Cells[3].Value.ToString();
            MbPhoneTb.Text = MembersDGV.SelectedRows[0].Cells[5].Value.ToString();
            MbAddressTb.Text = MembersDGV.SelectedRows[0].Cells[6].Value.ToString();
            if (MbNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(MembersDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void QuestionLbl_Click(object sender, EventArgs e)
        {
            Questions obj = new Questions();
            obj.Show();
            this.Hide();
        }

        private void LevelsLbl_Click(object sender, EventArgs e)
        {
            Levels obj = new Levels();
            obj.Show();
            this.Hide();
        }
    }
}
