using System;
using System.Data.Entity;
using System.Linq;
using LoginForm.DTO;
//namespace LoginForm
//{
    //public class QL : DbContext
   // {
        // Your context has been configured to use a 'QL' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'LoginForm.QL' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'QL' 
        // connection string in the application configuration file.
        //public QL()
         //   : base("name=QL")
      //  {
      //      Database.SetInitializer<QL>(new CreateDB());
     //   }
     //   public virtual DbSet<ImageDoanHinh> ImageDoanHinhs { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
   // }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
//}