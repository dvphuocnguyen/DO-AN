using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.DTO
{
    public class video
    {
        [Key]
        public string idvideo { get; set; }

        public string title { get; set; }
        public string transcript { get; set; }
        public string url { get; set; }
       
        public int luotview { get; set; }
        public DateTime ngaytao { get; set; }
    }
}
