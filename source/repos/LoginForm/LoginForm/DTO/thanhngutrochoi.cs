using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.DTO
{
    public class thanhngutrochoi
    {
        public thanhngutrochoi()
        {
            this.Khoahoc = new khoahoc();
        }
        [Key]
        public int id { get; set; }

        public string idcourse { get; set; }

        public string idtu { get; set; }

        [ForeignKey("idcourse")]

        public virtual khoahoc Khoahoc { get; set; }

    }
}
