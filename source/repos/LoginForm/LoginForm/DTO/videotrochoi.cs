using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.DTO
{
    public class videotrochoi
    {
        
        [Key]
        public string idvideotrochoi { get; set; }
        
        public string idkhoahoc { get; set; }
        public string idvideo { get; set; }
        [ForeignKey("idvideo")]
        public virtual video video { get; set; }
        [ForeignKey("idkhoahoc")]
        public virtual khoahoc Khoahoc { get; set; }

    }
}
