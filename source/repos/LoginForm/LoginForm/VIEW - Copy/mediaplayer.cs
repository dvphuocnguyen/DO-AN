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
        
        public mediaplayer()
        {
            InitializeComponent();
            this.AllowDrop = true;
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
            quizholeitem temp=BBLQL.Instance.quizhole("na no ma mi ne no xi ga me ta lo", 2);
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

            richTextBox1.Text = "The middle sentences in a paragraph are called supporting. Supporting sentences give examples or other details about the topic.";
           
        }

        private void richTextBox1_MouseLeave(object sender, EventArgs e)
        {
            Console.Write(richTextBox1.SelectedText);
        }
    }
}
