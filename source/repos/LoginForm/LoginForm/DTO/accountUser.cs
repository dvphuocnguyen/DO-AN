using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.DTO
{
    public class accountUser
    {


        [Key]
        public string id { get; set; }
        [Required]
        public string userName { get; set; }
        [Required]
        public string passwordUser { get; set; }


        

    }
}
