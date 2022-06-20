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
    public partial class Questions : Form
    {
        public Questions()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-455C16V\SQLEXPRESS;Initial Catalog=Quizdb;Integrated Security=True");

        private void Reset()
        {
            QuestionTb.Text = "";
            Op1Tb.Text = "";
            Op2Tb.Text = "";
            Op3Tb.Text = "";
            Op4Tb.Text = "";
            AnswerTb.Text = "";
            LvCb.SelectedIndex = 0;
        }
        private void GetLevels()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select LvName from Levelsstbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("LvName", typeof(string));
            dt.Load(rdr);
            LvCb.ValueMember = "LvName";
            LvCb.DataSource = dt;

            Con.Close();
        }
        private void DisplayQuestion()
        {
            Con.Open();
            string Query = "select * from Questiontbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            QuestionDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        int Key = 0;
        private void QuestionDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            QuestionTb.Text = QuestionDGV.SelectedRows[0].Cells[1].Value.ToString();
            Op1Tb.Text = QuestionDGV.SelectedRows[0].Cells[2].Value.ToString();
            Op2Tb.Text = QuestionDGV.SelectedRows[0].Cells[3].Value.ToString();
            Op3Tb.Text = QuestionDGV.SelectedRows[0].Cells[5].Value.ToString();
            Op4Tb.Text = QuestionDGV.SelectedRows[0].Cells[6].Value.ToString();
            AnswerTb.Text = QuestionDGV.SelectedRows[0].Cells[6].Value.ToString();
            LvCb.SelectedValue = QuestionDGV.SelectedRows[0].Cells[7].Value.ToString();
            if (QuestionTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(QuestionDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (QuestionTb.Text == "" || Op1Tb.Text == "" || Op2Tb.Text == "" || Op3Tb.Text == "" || Op4Tb.Text == "" || AnswerTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Questiontbl (QDesc,Q1,Q2,Q3,Q4,QA,QS) values (@Qd,@Q1,@Q2,@Q3,@Q4,@QA,@QS)", Con);
                    cmd.Parameters.AddWithValue("@Qd", QuestionTb.Text);
                    cmd.Parameters.AddWithValue("@Q1", Op1Tb.Text);
                    cmd.Parameters.AddWithValue("@Q2", Op2Tb.Text);
                    cmd.Parameters.AddWithValue("@Q3", Op3Tb.Text);
                    cmd.Parameters.AddWithValue("@Q4", Op4Tb.Text);
                    cmd.Parameters.AddWithValue("@QA", AnswerTb.Text);
                    cmd.Parameters.AddWithValue("@QS", LvCb.SelectedValue.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Added ");
                    Con.Close();
                    Reset();
                    DisplayQuestion();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (QuestionTb.Text == "" || Op1Tb.Text == "" || Op2Tb.Text == "" || Op3Tb.Text == "" || Op4Tb.Text == "" || AnswerTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update Questiontbl set QDesc=@Qd,Q1=@Q1,Q2=@Q2,Q3=@Q3,Q4=@Q4,QA=@QA,QS=@QS  where QId=@QKey", Con);
                    cmd.Parameters.AddWithValue("@Qd", QuestionTb.Text);
                    cmd.Parameters.AddWithValue("@Q1", Op1Tb.Text);
                    cmd.Parameters.AddWithValue("@Q2", Op2Tb.Text);
                    cmd.Parameters.AddWithValue("@Q3", Op3Tb.Text);
                    cmd.Parameters.AddWithValue("@Q4", Op4Tb.Text);
                    cmd.Parameters.AddWithValue("@QA", AnswerTb.Text);
                    cmd.Parameters.AddWithValue("@QS", LvCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@QKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Updated ");
                    Con.Close();
                    Reset();
                    DisplayQuestion();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Levels obj = new Levels();
            obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Members obj = new Members();
            obj.Show();
            this.Hide();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();    
        }
    }
}
