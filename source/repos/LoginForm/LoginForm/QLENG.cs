using System;
using System.Data.Entity;
using System.Linq;
using LoginForm.DTO;
namespace LoginForm
{
    public class QLENG : DbContext
    {
        // Your context has been configured to use a 'QLENG' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'LoginForm.QLENG' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'QLENG' 
        // connection string in the application configuration file.
        public QLENG()
            : base("name=QLENG1")
        {
            Database.SetInitializer<QLENG>(new CreateDB());
        }
        public virtual DbSet<ImageDoanHinh> ImageDoanHinhs { get; set; }
        public virtual DbSet<khoahoc> KhoaHocs { get; set; }
        
        public virtual DbSet<video> Videos { get; set; }

        public virtual DbSet<videotrochoi> Videotrochois { get; set; }

        public virtual DbSet<khoadahoc> Khoadahocs { get; set; }

        public virtual DbSet<inforuser> Inforusers { get; set; }

        public virtual DbSet<accountUser> AccountUsers { get; set; }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}