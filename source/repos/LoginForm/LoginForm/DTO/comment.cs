using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.DTO
{
    public class comment
    {
        [Key]
        public int ID { get; set; }
        public double rating { get; set; }
        public string noidung { get; set; }

        public DateTime ngaygui { get; set; }

    }
}
