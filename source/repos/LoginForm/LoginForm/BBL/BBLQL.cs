using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginForm.DTO;
namespace LoginForm.BBL
{
    internal class BBLQL
    {
        private static BBLQL _Instance;
        public static BBLQL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BBLQL();
                return _Instance;
            }
            private set { }

        }
        public quizholeitem quizhole(string chuoi,int sohole)
        {
            quizholeitem temp = new quizholeitem();
            String[] chuoisplit=chuoi.Split(' ');
            List<String> hole=new List<String>(sohole);
            List<int> randomlist = new List<int>();
            Random rand = new Random();
            for (int i=0;i<sohole;i++)
            {
                
                int random = rand.Next(0, chuoisplit.Length);
                while(randomlist.Contains(random))
                {
                    random = rand.Next(0, chuoisplit.Length);
                }
                randomlist.Add(random);
                hole.Add(chuoisplit[random]);
                
            }
            temp= new quizholeitem{
                chuoi = chuoisplit,
                listhole=hole,
                indexhole=randomlist,
            };
            return temp;
        }

        public void adduser(string taikhoan, string matkhau)
        {
            QLENG db = new QLENG();
            db.AccountUsers.Add(new accountUser { id = DateTime.Now.ToString(),userName=taikhoan,passwordUser=matkhau });
            db.SaveChanges();
        }
        public bool checkeduser(string taikhoan)
        {
            QLENG db=new QLENG();
            foreach(accountUser i in db.AccountUsers)
            {
                if(i.userName==taikhoan)
                {
                    return true;
                }
            }
            return false;
        }
       
        public bool checkuser(string taikhoan, string matkhau)
        {
            foreach (accountUser i in BBLQL.Instance.listallusers())
            {
                if (i.userName == taikhoan && i.passwordUser == matkhau)
                {
                    return true;
                }
            }
            return false;
        }
        public List<accountUser> listallusers()
        {
            List<accountUser> list = new List<accountUser>();
            QLENG db=new QLENG();
            foreach(accountUser i in db.AccountUsers)
            {
                list.Add(i);
            }
            return list;
        }
        public void adduser(string iduser,string firstName,string lastName,string gender,string email,DateTime sinhnhat,string roleUser,string urlAvatar)
        {
            QLENG db = new QLENG();
            db.Inforusers.Add(new inforuser
            {
                id=iduser,
                firstName=firstName,
                lastName=lastName,
                gender=gender,
                email=email,
                sinhnhat=sinhnhat,
                roleUser=roleUser,
                urlAvatar=urlAvatar,
            }) ;
            db.SaveChanges();
        }

        //game doan hinh
        public Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        public doanhinhDTO randomhinh(int index,string[] listHinhAnh,int[] listindex)
        {
            bool check;
            Random rd = new Random();
            do
            {
                
                index = rd.Next(0, listHinhAnh.Length);
                check = true;
                for (int i = 0; i < listindex.Length; i++)
                {
                   
                    if (index == listindex[i])
                    {
                        
                        check = false;
                        break;
                    }
                }
            } while (check == false);
            return new doanhinhDTO
            {
                
                listHinhAnh = listHinhAnh,
                index=index,
                listindex=listindex,
            };
        }

       

        public int lengthcrossword(string DapAn)
        {
            string[] splitwords = DapAn.Split(' ');
            string temp = "";
            foreach (string i in splitwords)
            {
                temp += i;
            }
            char[] words = temp.ToCharArray();
            
            return words.Length;
        }
        public char[] randomanswer(string DapAn)
        {
            string[] splitwords = DapAn.Split(' ');
            string temp = "";
            
            foreach (string i in splitwords)
            {
                temp += i;
            }          
            char[] words = temp.ToCharArray();
           
            char[] random=new char[words.Length*2];
            List<int> randomlist =new List<int>(words.Length*2);
            List<int> listusedwords=new List<int>(words.Length);
            Random rd = new Random();
            int index;
            int indexrandomwords;
            for (int i = 0; i < 2*words.Length; i++)
            {
                
                index = rd.Next(0, words.Length*2);
               
                while (randomlist.Contains(index))
                {
                    index = rd.Next(0, words.Length * 2 );
                }
                randomlist.Add(index);
                if (listusedwords.Count<words.Length)
                {
                    indexrandomwords = rd.Next(0, words.Length);
                    while (listusedwords.Contains(indexrandomwords))
                    {
                        indexrandomwords = rd.Next(0, words.Length);
                    }
                    listusedwords.Add(indexrandomwords);
                    random[index]=words[indexrandomwords];
                }
                 else if(randomlist.Count+1==words.Length)
                {
                    indexrandomwords = rd.Next(0, words.Length);
                    while (listusedwords.Contains(indexrandomwords))
                    {
                        indexrandomwords = rd.Next(0, words.Length);
                    }
                    listusedwords.Add(indexrandomwords);
                    random[index] = words[indexrandomwords];

                }    
                else random[index] =(char)rd.Next(65,91);


            }
           
            
            return random;
        }
        public bool checkdapanBBl(string temp, string[] listDapAn, int index)
        {
           
            //string dapan = (listDapAn[index].Split(' ')).ToString().ToUpper();            
            string temp1 = temp.ToUpper();
           
            if (temp1 == listDapAn[index].ToUpper())
                return true;
            else return false;
        }
        public void deletehinhanh(string msha)
        {
            QLENG db=new QLENG();
            ImageDoanHinh temp=db.ImageDoanHinhs.Find(msha);
            db.ImageDoanHinhs.Remove(temp);
            db.SaveChanges();
        }
        public void addhinhanh(string i,string urlfile,string dapan)
        {
            QLENG db = new QLENG();
            db.ImageDoanHinhs.Add(new ImageDoanHinh { id = i, url = urlfile, content = dapan });
            db.SaveChanges();
        }
        //Tao Khoa Hoc Video
        public void addKhoaHocVideo(string id,string titlekhoahoc,string linkvideo,string author,string titlevideo,string transcript)
        {
            QLENG db = new QLENG();
            db.KhoaHocs.Add(new khoahoc {idkhoahoc=id,tittle=titlekhoahoc,ngaytao=DateTime.Now,nguoitao=author});
            db.Videos.Add(new video { idvideo = id, title = titlevideo, ngaytao = DateTime.Now, luotview = 0, url = linkvideo, transcript = transcript });            
            db.SaveChanges();
            db.Videotrochois.Add(new videotrochoi { idvideotrochoi = id, idkhoahoc = id, idvideo = id });
            db.SaveChanges();
        }
        public void deletekhoahoctrochoi(string id)
        {
            QLENG db = new QLENG();
            videotrochoi vdtc=db.Videotrochois.Find(id);
            db.Videotrochois.Remove(vdtc);
            db.SaveChanges();
            khoahoc kh=db.KhoaHocs.Find(id);
            db.KhoaHocs.Remove(kh);
            video vd=db.Videos.Find(id);
            db.Videos.Remove(vd);
            db.SaveChanges();

        }

        //trie
        

        //thong ke

        public double thongkediem()
        {
            QLENG db = new QLENG();
            return 6.3;
            
        }
        public void addKhoaHocDaHoc(string iduser,string idkhoahoc)
        {
            QLENG db = new QLENG();
            db.Khoadahocs.Add(new khoadahoc { id = iduser + Convert.ToString(DateTime.Now),iduser=iduser,idkhoahoc=idkhoahoc });
            db.SaveChanges();
        }
        public List<khoadahoc> ShowKhoaDaHoc(string query)
        {
            QLENG db = new QLENG();
            List<khoadahoc> list = new List<khoadahoc>();
            foreach(khoadahoc i in db.Khoadahocs)
            {
               
            }
            return list; 
        }
        public List<String> recommendlist(string goiy)
        {
            List<String> list = new List<String>();
            
            return list;
        }
        public List<int> searchparagraph(string paragraph,string par,trietree tree)
        {
            List<int> list = new List<int>();
            Console.WriteLine("vl");            
            list=tree.search_tree(par);
            return list;
        }
        public string addParagraphGUI(string id)
        {
            QLENG db = new QLENG();
            videotrochoi vdtc=db.Videotrochois.Find(id);
            return vdtc.video.transcript;
         }
        //public List<int> searchstring(string paragrapth)
       // {

        //}
    }
}