using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.DTO
{
    public class ImageDoanHinh
    {
        [Key]
        public  string id { get; set; }
        [Required]
        public string url { get; set; }

        public string content { get; set; }
    }
}
