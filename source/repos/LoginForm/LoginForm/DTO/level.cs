using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.DTO
{
    public class level
    {
        [Key]
        public string ID { get; set; }
        [Required]
        public string band { get; set; }


    }
}
