using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.DTO
{
    public class tudientrochoi
    {
        public tudientrochoi()
        {
            this.tudien = new tudien();
            this.khoahoc = new khoahoc();
        }
        [Key]
        public string id { get; set; }
        public string idkhoahoc { get; set; }
        public string idtu { get; set; }
        [ForeignKey("idtu")]
        public virtual tudien tudien { get; set; }
        [ForeignKey("idkhoahoc")]
        public virtual khoahoc khoahoc { get; set; }

    }
}
