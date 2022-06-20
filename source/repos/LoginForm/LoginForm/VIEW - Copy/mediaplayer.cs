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
    public partial class mediaplayer : Form
    {
         private string resume;
        public string idvideotrochoi;
        trietree tree;
        public mediaplayer(string id)
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.idvideotrochoi = id;
            this.tree = new trietree(BBLQL.Instance.addParagraphGUI(idvideotrochoi));
            GUI();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1=new OpenFileDialog();
            openFileDialog1.Filter = "(mp3,wav,mp4,mov,wmv,mpg)|*.mp3;*.wav;*.mp4;*.mov;*.wmv;*.mpg|all files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text= openFileDialog1.FileName;
            }
            resume = "Start";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (resume == "Start")
            {
                axWindowsMediaPlayer1.URL = textBox1.Text;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                resume = "Resume";
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void GUI()
        {   
            string text= BBLQL.Instance.addParagraphGUI(idvideotrochoi);
            richTextBox1.Text = text;
            var rand=new Random();
            quizholeitem temp=BBLQL.Instance.quizhole(text, rand.Next(text.Length/20));
            Control[]list=new Control[temp.chuoi.Length];
            
            for (int i=0;i<temp.chuoi.Length;i++)
            {
                if (temp.indexhole.Contains(i) == false)
                {
                    Label  a = new Label();
                    a.Size = new Size(40, 20);
                    a.Text = temp.chuoi[i];
                    a.Location = new Point(groupBox1.Location.X+(i%30)*(a.Width+5),groupBox1.Location.Y+5+(i/30)*a.Height);
                    list[i]=a;                    
                }
                
                else
                {
                    TextBox b = new TextBox();
                    b.Size = new Size(40, 20);
                    b.Location = new Point(groupBox1.Location.X + (i % 30) * (b.Width + 5), groupBox1.Location.Y + 5 + (i / 30) * b.Height);
                    list[i] = b;

                }
            }
            groupBox1.Controls.AddRange(list);
           /* tabControl1.Controls.Add();*/
            
           
        }

        private void richTextBox1_MouseLeave(object sender, EventArgs e)
        {
            Console.Write(richTextBox1.SelectedText);
        }

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            reloadParagraph();
            string paragraph = richTextBox1.Text;
            string[] pars = textBox2.Text.Split(',');
            foreach (string par in pars)
            {
                Console.WriteLine(par);
                List<int> indexes = BBLQL.Instance.searchparagraph(paragraph, par,tree);
               
                if (indexes != null)
                {
                    foreach (int index in indexes)
                    {
                        
                        richTextBox1.SelectionStart = index;
                        richTextBox1.SelectionLength = par.Length;
                        richTextBox1.SelectionBackColor = Color.Yellow;

                    }
                }
                
            }
        }
        private void reloadParagraph()
        {
            richTextBox1.SelectionStart = 0;
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor= Color.White;
        }

       
    }
}
