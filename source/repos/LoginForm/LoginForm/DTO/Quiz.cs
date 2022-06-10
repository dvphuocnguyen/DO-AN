using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.DTO
{
    public class Quiz
    {

        [Key]
        public string id { get; set; }
        public string idkhoahoc { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }


    }
}
