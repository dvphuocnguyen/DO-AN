using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class BookList
    {
        private List<Book> list;
        public void Sort()
        {
            list.Sort();
        }
        public void Xuat()
        {
            list.ForEach(item =>
            {
                item.Xuat();
            });
        }
    public void Nhap()
        {
            list = new List<Book>()
            {
                new Book(){TenSach = "Java", TenTacGia ="Peter", NhaXuatBan="Wiley", NamXuatBan=2010,Danh}
            };
        }
    }
}
