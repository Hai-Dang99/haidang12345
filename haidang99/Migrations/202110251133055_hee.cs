namespace haidang99.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hee : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SinhViens",
                c => new
                    {
                        MaSinhVien = c.String(nullable: false, maxLength: 128),
                        TenSinhVien = c.String(),
                    })
                .PrimaryKey(t => t.MaSinhVien);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SinhViens");
        }
    }
}
