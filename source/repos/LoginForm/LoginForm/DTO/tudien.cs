using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.DTO
{
    public class tudien
    {
        public tudien()
        {
            this.audio = new audio();
        }
        [Key]
        public string id { get; set; }
        public string tu { get; set; }
        public string loaitu { get; set; }
        public string phienam { get; set; }
        public string dichnghia { get; set; }

        public string idaudio { get; set; }
        public DateTime ngaytao { get; set; }
        [ForeignKey("idaudio")]
        public virtual audio audio { get; set; }
    }
}
