using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.DTO
{
    public class audio
    {
        [Key]
        public string id { get; set; }

        public string tittle { get; set; }
        public string noidung { get; set; }

        public string link { get; set; }

        public int luotview { get; set; }
        public DateTime ngaytao { get; set; }
        public bool active { get; set; }

        public string urlaudio { get; set; }
    }
}
