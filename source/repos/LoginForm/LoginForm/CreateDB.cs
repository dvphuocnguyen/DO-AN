using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace LoginForm
{
    public class CreateDB:DropCreateDatabaseIfModelChanges<QLENG>
    {
        protected override void Seed(QLENG context)
        {
            
        }
    }
}
