using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class Book : IBook,IComparable<Book>
    {
        private object other;

        public string TenSach { get; set; }
        public string TenTacGia { get; set; }
        public string NhaXuatBan { get; set; }
        public int NamXuatBan { get; set; }
        public string Isbn { get; set; }
        public string DanhMuc { get; set; }

      
      

        public int CompareTo(Book other)
        {
            return this.TenSach.CompareTo(other.TenSach);
        }
        public void Nhap()
        {
            throw new NotImplementedException();
        }
        public void Xuat()
        {
            Console.WriteLine($"{TenSach} - {TenTacGia} - {NamXuatBan} - {NhaXuatBan} - {Isbn} - {DanhMuc}");
        }
    }
}
