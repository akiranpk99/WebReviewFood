namespace WebReviewFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableReviewFoodCategory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        LoaiMonAn = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ReviewFoods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenBaiReview = c.String(nullable: false, maxLength: 255),
                        ThongtinFood = c.String(nullable: false),
                        DanhGiaFood = c.String(nullable: false),
                        ImageCover = c.String(nullable: false),
                        IdCategory = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            DropTable("dbo.ReviewFoods");
            DropTable("dbo.Categories");
        }
    }
}
