using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginForm.DTO;
using LoginForm.BBL;
namespace LoginForm
{
    public partial class doanhinh : Form
    {
        
        
        int index;
        int indexdadung = 0;
        //int diem;
        string[] listHinhAnh;
        int[] listindex;
        int timeremainder;
        string[] listDapAn;
        Button[] listBtn;
        Button[] listbtndapan;
        public doanhinh()
        {
            InitializeComponent();
            QLENG db = new QLENG();
        }

       
        private void chuyenquacautieptheo()
        {

           
            timerReload();
            XoaBtnDapAn();
            deleteallrandom();
            doanhinhDTO temp = BBLQL.Instance.randomhinh( index, listHinhAnh, listindex);
           
            index = temp.index;
            for (int i = 0; i < temp.listindex.Length; i++)
            {
                listindex[i] = temp.listindex[i];
            }
            for (int i = 0; i < temp.listHinhAnh.Length; i++)
            {
                listHinhAnh[i] = temp.listHinhAnh[i];
            }

            pictureBox1.BackgroundImage = Image.FromFile(listHinhAnh[index]);
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            
            listindex[++indexdadung] = index;
            Console.WriteLine(indexdadung);
            label1.Text = "So diem cua ban : " + (5 * (indexdadung)).ToString();
           
            TaoBtnDapAn();
            randomdapan();
            

        }
        
        private void TaoBtnDapAn()
        {
            listbtndapan= new Button[BBLQL.Instance.lengthcrossword(listDapAn[index])];
            
            for (int i = 0; i < BBLQL.Instance.lengthcrossword(listDapAn[index]); i++)
            {
                
                listbtndapan[i] = new Button();
                listbtndapan[i].Height = 35;
                listbtndapan[i].Width = 50;
                listbtndapan[i].TextAlign = ContentAlignment.MiddleCenter;
                listbtndapan[i].Font = new Font("Microsoft Sans Serif", 15);
                listbtndapan[i].Location = new Point((pictureBox1.Location.X + (i%8) * (listbtndapan[i].Size.Width + 15)), pictureBox1.Location.Y + pictureBox1.Size.Height + 15 +(i/8)*(listbtndapan[i].Size.Height));
                listbtndapan[i].Click +=eventBtnDapAn;
               
                this.Controls.Add(listbtndapan[i]);
            }
        }
        private void eventBtnDapAn(object sender,EventArgs e)
        {
            Button temp = (Button)sender;
            for(int i=0;i<listBtn.Length;i++)
            {
                if(listBtn[i].Text==temp.Text&&listBtn[i].Visible==false)
                {
                      
                    listBtn[i].Visible = true;
                    temp.Text = "";
                }
            }

        }
        private void XoaBtnDapAn()
        {
           
            for (int i = 0; i < listbtndapan.Length; i++)
            {
                this.Controls.Remove(listbtndapan[i]);
                
            }
        }



        private void doanhinh_Load(object sender, EventArgs e)
        {
            QLENG db = new QLENG();
            timerReload();
            label1.Text = "So diem cua ban : 0";
            int soluong = db.ImageDoanHinhs.Count();
            listHinhAnh =new string[soluong];
            listDapAn=new string[soluong];
            listindex = new int[soluong];
            for(int i=0;i<listindex.Length;i++)
            {
                listindex[i] = -1;
            }           
            int indexhinhanh = 0;
            foreach(ImageDoanHinh i in db.ImageDoanHinhs)
            {
                listHinhAnh[indexhinhanh] = i.url;
                listDapAn[indexhinhanh] = i.content;
                indexhinhanh++;
            }
            
          
            Random rd =new Random();
            index = rd.Next(0, listHinhAnh.Length);
            listindex[indexdadung] = index;
           
            TaoBtnDapAn();
            randomdapan();
            pictureBox1.BackgroundImage = Image.FromFile(listHinhAnh[index]);
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            
        }
        void deleteallrandom()
        {
            for(int i=0;i< listBtn.Length;i++)
            {

                this.Controls.Remove(listBtn[i]);
            }
        }
        private void randomdapan()
        {            
            char[] dapanrandom = BBLQL.Instance.randomanswer(listDapAn[index]);

            listBtn = new Button[dapanrandom.Length];
            for (int i = 0; i < dapanrandom.Length; i++)
            {
                
                if (i % 2 == 0)
                {
                    listBtn[i] = new Button();
                    listBtn[i].Text = Convert.ToString(dapanrandom[i]);
                    listBtn[i].Location = new Point(pictureBox1.Location.X + pictureBox1.Width + 30, pictureBox1.Location.Y + i * listBtn[i].Height);
                    listBtn[i].Click += newBtn_Click;
                    this.Controls.Add(listBtn[i]);
                }
                else
                {
                    listBtn[i] = new Button();
                    listBtn[i].Text = Convert.ToString(dapanrandom[i]);
                    listBtn[i].Location = new Point(pictureBox1.Location.X + pictureBox1.Width + 50 + listBtn[i].Width, pictureBox1.Location.Y + (i - 1) * listBtn[i].Height);
                    listBtn[i].Click += newBtn_Click;
                    this.Controls.Add(listBtn[i]);
                }

            }
        }
        private void newBtn_Click(object sender,EventArgs e)
        {
            
            for(int i=0;i<listbtndapan.Length;i++)
            {
                
                if(listbtndapan[i].Text =="")
                {
                    
                    Button temp = (Button)sender;
                    listbtndapan[i].Text = temp.Text;
                    if (i == listbtndapan.Length - 1)
                    {
                        if (checkDapAn(listDapAn, index, listbtndapan))
                        {
                            MessageBox.Show("dung roi");
                            if (indexdadung < listHinhAnh.Length-1)
                            {

                                chuyenquacautieptheo();
                            }
                            else
                            {
                                label1.Text = "So diem cua ban : " + (5 * (indexdadung+1)).ToString();
                                MessageBox.Show("Ban da thang");
                            }
                            
                            
                        }
                        else
                        {
                            MessageBox.Show("sai roi");
                        }
                    }
                    temp.Visible = false;
                                
                    break; 
                    
                }
                
                
               
            }   
            
        }
        private bool checkDapAn(string[] listDapAn, int index, Button[] listbtndapan)
        {
            
            string temp = "";
            for (int i = 0; i < listbtndapan.Length; i++)
            {
                temp += listbtndapan[i].Text;
            }
            return BBLQL.Instance.checkdapanBBl(temp,listDapAn,index);
        }
        private void timerReload()
        {
            timeremainder = 120;
            label2.Text = "Thoi gian con lai : 120";
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeremainder--;
            label2.Text="Thoi gian con lai : "+timeremainder.ToString();
            if(timeremainder == 0)
            {                
                timer1.Stop();
                MessageBox.Show("Het gio. Ban da thua !!!");
                this.Close();
            }
            
        }
    }
}
