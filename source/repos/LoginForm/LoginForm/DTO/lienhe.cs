using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.DTO
{
    public class lienhe
    {
        public lienhe()
        {
            this.Khoahoc = new khoahoc();
            this.comment = new comment();
            this.user = new inforuser();
        }
        [Key]
        public string id { get; set; }
        public string idbaihoc { get; set; }
        public string idcomment { get; set; }
        public string iduser { get; set; }

        [ForeignKey("idbaihoc")]
        public khoahoc Khoahoc { get; set; }

        [ForeignKey("idcomment")]
        public virtual comment comment { get; set; }
        [ForeignKey("iduser")]
        public virtual inforuser user { get; set; }

    }
}
