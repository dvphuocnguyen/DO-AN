using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.DTO
{
    public class thanhngu
    {
        [Key]
        public string id { get; set; }
        public string noidung { get; set; }
        public string vidu { get; set; }
        public DateTime ngaytao { get; set; }

    }
}
