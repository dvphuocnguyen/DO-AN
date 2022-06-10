using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.DTO
{
    public class khoahoc
    {
        [Key]
        public string idkhoahoc { get; set; }
        public string tittle { get; set; }

        
        public DateTime ngaytao { get; set; }

        public string nguoitao { get; set; }       

    }
}
