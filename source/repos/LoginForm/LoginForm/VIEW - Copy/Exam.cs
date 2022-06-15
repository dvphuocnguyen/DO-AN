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
    public partial class Exam : Form
    {
        public Exam()
        {
            InitializeComponent();
            //multiRandom();
            FetchQuestion();
            timer1.Start();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-455C16V\SQLEXPRESS;Initial Catalog=Quizdb;Integrated Security=True");
        string a1, a2, a3, a4, a5, a6, a7, a8, a9, a10;
        string[] Ua = new string[10];
        private void Q1O1_CheckedChanged(object sender, EventArgs e)
        {
            //Ua[0] = Q1O1.Text; 
            //MessageBox.Show("Selected is "+ Ua[0]);
        }

        private void Q1O2_CheckedChanged(object sender, EventArgs e)
        {

            //Ua[0] = Q1O2.Text;
            //MessageBox.Show("Selected is " + Ua[0]);
        }
     
        

        private int GererateRandom()
        {
            Random rd = new Random();
            int x = rd.Next(1, 4);
            int y = rd.Next(1, 4);
            int z = rd.Next(1, 4);
            MessageBox.Show("" + x + "and" + y + "and" + z);
            return x;
        }
        int chrono = 1000;
        int Count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            chrono -= 1;
            Count += 1;
            TimingBar.Value = Count;
            TimeLbl.Text = "" + chrono;
            if (TimingBar.Value == 1000)
            {
                TimingBar.Value = 0;
                timer1.Stop();
                MessageBox.Show("Time over!!");
                Form1 log = new Form1();
                this.Hide();
            }
        }

        int[] Keys = new int[10];
        private void multiRandom()
        {
            HashSet<int> numbers = new HashSet<int>();
            var rnd = new Random();
            while (numbers.Count < 10)
            {
                numbers.Add(rnd.Next(1, 11));

            }
            for (int i = 0; i < 10; i++)
            {
                Keys[i] = numbers.ElementAt(i);
            }
        }
        private void FetchQuestion()
        {
            try
            {
                //int QNum = GererateRandom();
                multiRandom();
                Con.Open();
                string Query = "select * from Questiontbl where QId=" + Keys[0] + "";
                SqlCommand cmd = new SqlCommand(Query, Con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                for (int i = 0; i <= 4; i++)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Q1.Text = dr["QDesc"].ToString();
                        Q1O1.Text = dr["Q1"].ToString();
                        Q1O2.Text = dr["Q2"].ToString();
                        Q1O3.Text = dr["Q3"].ToString();
                        Q1O4.Text = dr["Q4"].ToString();
                        a1 = dr["QA"].ToString();
                    }
                }
                string Query1 = "select * from Questiontbl where QId=" + Keys[1] + "";
                cmd = new SqlCommand(Query1, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                for (int i = 0; i <= 4; i++)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Q2.Text = dr["QDesc"].ToString();
                        Q2O1.Text = dr["Q1"].ToString();
                        Q2O2.Text = dr["Q2"].ToString();
                        Q2O3.Text = dr["Q3"].ToString();
                        Q2O4.Text = dr["Q4"].ToString();
                        a2 = dr["QA"].ToString();
                    }
                }
                string Query2 = "select * from Questiontbl where QId=" + Keys[2] + "";
                cmd = new SqlCommand(Query2, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                for (int i = 0; i <= 4; i++)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Q3.Text = dr["QDesc"].ToString();
                        Q3O1.Text = dr["Q1"].ToString();
                        Q3O2.Text = dr["Q2"].ToString();
                        Q3O3.Text = dr["Q3"].ToString();
                        Q3O4.Text = dr["Q4"].ToString();
                        a3 = dr["QA"].ToString();
                    }
                }
                string Query3 = "select * from Questiontbl where QId=" + Keys[3] + "";
                cmd = new SqlCommand(Query3, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                for (int i = 0; i <= 4; i++)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Q4.Text = dr["QDesc"].ToString();
                        Q4O1.Text = dr["Q1"].ToString();
                        Q4O2.Text = dr["Q2"].ToString();
                        Q4O3.Text = dr["Q3"].ToString();
                        Q4O4.Text = dr["Q4"].ToString();
                        a4 = dr["QA"].ToString();
                    }
                }
                string Query4 = "select * from Questiontbl where QId=" + Keys[4] + "";
                cmd = new SqlCommand(Query4, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                for (int i = 0; i <= 4; i++)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Q5.Text = dr["QDesc"].ToString();
                        Q5O1.Text = dr["Q1"].ToString();
                        Q5O2.Text = dr["Q2"].ToString();
                        Q5O3.Text = dr["Q3"].ToString();
                        Q5O4.Text = dr["Q4"].ToString();
                        a5 = dr["QA"].ToString();
                    }
                }
                string Query5 = "select * from Questiontbl where QId=" + Keys[5] + "";
                cmd = new SqlCommand(Query5, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                for (int i = 0; i <= 4; i++)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Q6.Text = dr["QDesc"].ToString();
                        Q6O1.Text = dr["Q1"].ToString();
                        Q6O2.Text = dr["Q2"].ToString();
                        Q6O3.Text = dr["Q3"].ToString();
                        Q6O4.Text = dr["Q4"].ToString();
                        a6 = dr["QA"].ToString();
                    }
                }
                string Query6 = "select * from Questiontbl where QId=" + Keys[6] + "";
                cmd = new SqlCommand(Query6, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                for (int i = 0; i <= 4; i++)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Q7.Text = dr["QDesc"].ToString();
                        Q7O1.Text = dr["Q1"].ToString();
                        Q7O2.Text = dr["Q2"].ToString();
                        Q7O3.Text = dr["Q3"].ToString();
                        Q7O4.Text = dr["Q4"].ToString();
                        a7 = dr["QA"].ToString();
                    }
                }
                string Query7 = "select * from Questiontbl where QId=" + Keys[7] + "";
                cmd = new SqlCommand(Query7, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                for (int i = 0; i <= 4; i++)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Q8.Text = dr["QDesc"].ToString();
                        Q8O1.Text = dr["Q1"].ToString();
                        Q8O2.Text = dr["Q2"].ToString();
                        Q8O3.Text = dr["Q3"].ToString();
                        Q8O4.Text = dr["Q4"].ToString();
                        a8 = dr["QA"].ToString();
                    }
                }
                string Query8 = "select * from Questiontbl where QId=" + Keys[8] + "";
                cmd = new SqlCommand(Query8, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                for (int i = 0; i <= 4; i++)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Q9.Text = dr["QDesc"].ToString();
                        Q9O1.Text = dr["Q1"].ToString();
                        Q9O2.Text = dr["Q2"].ToString();
                        Q9O3.Text = dr["Q3"].ToString();
                        Q9O4.Text = dr["Q4"].ToString();
                        a9 = dr["QA"].ToString();
                    }
                }
                string Query9 = "select * from Questiontbl where QId=" + Keys[9] + "";
                cmd = new SqlCommand(Query9, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                for (int i = 0; i <= 4; i++)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Q10.Text = dr["QDesc"].ToString();
                        Q10O1.Text = dr["Q1"].ToString();
                        Q10O2.Text = dr["Q2"].ToString();
                        Q10O3.Text = dr["Q3"].ToString();
                        Q10O4.Text = dr["Q4"].ToString();
                        a10 = dr["QA"].ToString();
                    }
                }
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error");
            }
        }
        int Score = 0;
        private void checkQ1()
        {

            if (Q1O1.Checked)
            {
                Ua[0] = "";
                Ua[0] = (Q1O1.Text);
            }
            else if (Q1O2.Checked)
            {
                Ua[0] = "";
                Ua[0] = (Q1O2.Text);
            }
            else if (Q1O3.Checked)
            {
                Ua[0] = "";
                Ua[0] = (Q1O3.Text);
            }
            else if (Q1O4.Checked)
            {
                Ua[0] = "";
                Ua[0] = (Q1O4.Text);
            }
            if (Ua[0] == a1)
            {
                Score = Score + 1;
            }
            else
            {
                Score = Score;
            }
        }
        private void checkQ2()
        {

            if (Q2O1.Checked)
            {
                Ua[1] = "";
                Ua[1] = (Q2O1.Text);
            }
            else if (Q2O2.Checked)
            {
                Ua[1] = "";
                Ua[1] = (Q2O2.Text);
            }
            else if (Q2O3.Checked)
            {
                Ua[1] = "";
                Ua[1] = (Q2O3.Text);
            }
            else if (Q2O4.Checked)
            {
                Ua[1] = "";
                Ua[1] = (Q2O4.Text);
            }
            if (Ua[1] == a2)
            {
                Score = Score + 1;
            }
            else
            {
                Score = Score;
            }
        }
        private void checkQ3()
        {

            if (Q3O1.Checked)
            {
                Ua[2] = "";
                Ua[2] = (Q3O1.Text);
            }
            else if (Q3O2.Checked)
            {
                Ua[2] = "";
                Ua[2] = (Q3O2.Text);
            }
            else if (Q3O3.Checked)
            {
                Ua[2] = "";
                Ua[2] = (Q3O3.Text);
            }
            else if (Q3O4.Checked)
            {
                Ua[2] = "";
                Ua[2] = (Q3O4.Text);
            }
            if (Ua[2] == a3)
            {
                Score = Score + 1;
            }
            else
            {
                Score = Score;
            }
        }
        private void checkQ4()
        {

            if (Q4O1.Checked)
            {
                Ua[3] = "";
                Ua[3] = (Q4O1.Text);
            }
            else if (Q4O2.Checked)
            {
                Ua[3] = "";
                Ua[3] = (Q4O2.Text);
            }
            else if (Q4O3.Checked)
            {
                Ua[3] = "";
                Ua[3] = (Q4O3.Text);
            }
            else if (Q4O4.Checked)
            {
                Ua[3] = "";
                Ua[3] = (Q4O4.Text);
            }
            if (Ua[3] == a4)
            {
                Score = Score + 1;
            }
            else
            {
                Score = Score;
            }
        }
        private void checkQ5()
        {

            if (Q5O1.Checked)
            {
                Ua[4] = "";
                Ua[4] = (Q5O1.Text);
            }
            else if (Q5O2.Checked)
            {
                Ua[4] = "";
                Ua[4] = (Q5O2.Text);
            }
            else if (Q5O3.Checked)
            {
                Ua[4] = "";
                Ua[4] = (Q5O3.Text);
            }
            else if (Q5O4.Checked)
            {
                Ua[4] = "";
                Ua[4] = (Q5O4.Text);
            }
            if (Ua[4] == a5)
            {
                Score = Score + 1;
            }
            else
            {
                Score = Score;
            }
        }
        private void checkQ6()
        {

            if (Q6O1.Checked)
            {
                Ua[5] = "";
                Ua[5] = (Q6O1.Text);
            }
            else if (Q6O2.Checked)
            {
                Ua[5] = "";
                Ua[5] = (Q6O2.Text);
            }
            else if (Q6O3.Checked)
            {
                Ua[5] = "";
                Ua[5] = (Q6O3.Text);
            }
            else if (Q6O4.Checked)
            {
                Ua[5] = "";
                Ua[5] = (Q6O4.Text);
            }
            if (Ua[5] == a6)
            {
                Score = Score + 1;
            }
            else
            {
                Score = Score;
            }
        }
        private void checkQ7()
        {

            if (Q7O1.Checked)
            {
                Ua[6] = "";
                Ua[6] = (Q7O1.Text);
            }
            else if (Q7O2.Checked)
            {
                Ua[6] = "";
                Ua[6] = (Q7O2.Text);
            }
            else if (Q7O3.Checked)
            {
                Ua[6] = "";
                Ua[6] = (Q7O3.Text);
            }
            else if (Q7O4.Checked)
            {
                Ua[6] = "";
                Ua[6] = (Q7O4.Text);
            }
            if (Ua[6] == a7)
            {
                Score = Score + 1;
            }
            else
            {
                Score = Score;
            }
        }
        private void checkQ8()
        {

            if (Q8O1.Checked)
            {
                Ua[7] = "";
                Ua[7] = (Q8O1.Text);
            }
            else if (Q8O2.Checked)
            {
                Ua[7] = "";
                Ua[7] = (Q8O2.Text);
            }
            else if (Q7O3.Checked)
            {
                Ua[7] = "";
                Ua[7] = (Q8O3.Text);
            }
            else if (Q8O4.Checked)
            {
                Ua[7] = "";
                Ua[7] = (Q8O4.Text);
            }
            if (Ua[7] == a8)
            {
                Score = Score + 1;
            }
            else
            {
                Score = Score;
            }
        }
        private void checkQ9()
        {

            if (Q9O1.Checked)
            {
                Ua[8] = "";
                Ua[8] = (Q9O1.Text);
            }
            else if (Q9O2.Checked)
            {
                Ua[8] = "";
                Ua[8] = (Q9O2.Text);
            }
            else if (Q9O3.Checked)
            {
                Ua[8] = "";
                Ua[8] = (Q9O3.Text);
            }
            else if (Q9O4.Checked)
            {
                Ua[8] = "";
                Ua[8] = (Q9O4.Text);
            }
            if (Ua[8] == a9)
            {
                Score = Score + 1;
            }
            else
            {
                Score = Score;
            }
        }
        private void checkQ10()
        {

            if (Q10O1.Checked)
            {
                Ua[9] = "";
                Ua[9] = (Q10O1.Text);
            }
            else if (Q10O2.Checked)
            {
                Ua[9] = "";
                Ua[9] = (Q10O2.Text);
            }
            else if (Q10O3.Checked)
            {
                Ua[9] = "";
                Ua[9] = (Q10O3.Text);
            }
            else if (Q10O4.Checked)
            {
                Ua[9] = "";
                Ua[9] = (Q10O4.Text);
            }
            if (Ua[9] == a10)
            {
                Score = Score + 1;
            }
            else
            {
                Score = Score;
            }
        }
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            Score = 0;
            checkQ1();
            checkQ2();
            checkQ3();
            checkQ4();
            checkQ5();
            checkQ6();
            checkQ7();
            checkQ8();
            checkQ9();
            checkQ10();
            MessageBox.Show("Score : " + Score);
        }

    }
}
