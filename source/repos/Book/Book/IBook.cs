using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public interface IBook
    {
            string TenSach { get; set; }
            string TenTacGia { get; set; }
            string NhaXuatBan { get; set; }
            int NamXuatBan { get; set; }
            string Isbn { get; set; }
            string DanhMuc { get; set; }

            void Xuat();
            void Nhap();

    }
}
