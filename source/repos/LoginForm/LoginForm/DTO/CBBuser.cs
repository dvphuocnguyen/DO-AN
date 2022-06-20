using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.DTO
{
    public class CBBuser
    {
     public string roleUser { get; set; }
        public override string ToString()
        {
            return roleUser;
        }
    }
}
