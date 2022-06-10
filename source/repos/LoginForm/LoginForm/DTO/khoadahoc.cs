using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.DTO
{
    public class khoadahoc
    {
        public khoadahoc()
        {
            this.Khoahoc = new khoahoc();
            this.InfoUser = new inforuser();
        }
        [Key]
        public string id { get; set; }
        public string idkhoahoc { get; set; }
        public string iduser { get; set; }
        [ForeignKey("idkhoahoc")]
        public khoahoc Khoahoc { get; set; }
        [ForeignKey("iduser")]
        public virtual inforuser InfoUser { get; set; }


    }
}
