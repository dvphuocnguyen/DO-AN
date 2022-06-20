namespace LoginForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            /*CreateTable(
                "dbo.accountUsers",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        userName = c.String(nullable: false),
                        passwordUser = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ImageDoanHinhs",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        url = c.String(nullable: false),
                        content = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.inforusers",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        firstName = c.String(),
                        lastName = c.String(),
                        gender = c.String(),
                        email = c.String(),
                        sinhnhat = c.DateTime(nullable: false),
                        roleUser = c.String(),
                        urlAvatar = c.String(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.accountUsers", t => t.id)
                .Index(t => t.id);
            
            CreateTable(
                "dbo.khoadahocs",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        idkhoahoc = c.String(maxLength: 128),
                        iduser = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.inforusers", t => t.iduser)
                .ForeignKey("dbo.khoahocs", t => t.idkhoahoc)
                .Index(t => t.idkhoahoc)
                .Index(t => t.iduser);
            
            CreateTable(
                "dbo.khoahocs",
                c => new
                    {
                        idkhoahoc = c.String(nullable: false, maxLength: 128),
                        tittle = c.String(),
                        ngaytao = c.DateTime(nullable: false),
                        nguoitao = c.String(),
                    })
                .PrimaryKey(t => t.idkhoahoc);
            
            CreateTable(
                "dbo.videos",
                c => new
                    {
                        idvideo = c.String(nullable: false, maxLength: 128),
                        title = c.String(),
                        transcript = c.String(),
                        url = c.String(),
                        luotview = c.Int(nullable: false),
                        ngaytao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.idvideo);
            
            CreateTable(
                "dbo.videotrochois",
                c => new
                    {
                        idvideotrochoi = c.String(nullable: false, maxLength: 128),
                        idkhoahoc = c.String(maxLength: 128),
                        idvideo = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.idvideotrochoi)
                .ForeignKey("dbo.khoahocs", t => t.idkhoahoc)
                .ForeignKey("dbo.videos", t => t.idvideo)
                .Index(t => t.idkhoahoc)
                .Index(t => t.idvideo);
            */
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.videotrochois", "idvideo", "dbo.videos");
            DropForeignKey("dbo.videotrochois", "idkhoahoc", "dbo.khoahocs");
            DropForeignKey("dbo.khoadahocs", "idkhoahoc", "dbo.khoahocs");
            DropForeignKey("dbo.khoadahocs", "iduser", "dbo.inforusers");
            DropForeignKey("dbo.inforusers", "id", "dbo.accountUsers");
            DropIndex("dbo.videotrochois", new[] { "idvideo" });
            DropIndex("dbo.videotrochois", new[] { "idkhoahoc" });
            DropIndex("dbo.khoadahocs", new[] { "iduser" });
            DropIndex("dbo.khoadahocs", new[] { "idkhoahoc" });
            DropIndex("dbo.inforusers", new[] { "id" });
            DropTable("dbo.videotrochois");
            DropTable("dbo.videos");
            DropTable("dbo.khoahocs");
            DropTable("dbo.khoadahocs");
            DropTable("dbo.inforusers");
            DropTable("dbo.ImageDoanHinhs");
            DropTable("dbo.accountUsers");
        }
    }
}
