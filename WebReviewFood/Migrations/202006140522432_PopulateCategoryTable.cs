namespace WebReviewFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES(ID,LoaiMonAn) VALUES(1,N'Thức Ăn Nhanh')");
            Sql("INSERT INTO CATEGORIES(ID,LoaiMonAn) VALUES(2,N'Thức Ăn Vặt')");
            Sql("INSERT INTO CATEGORIES(ID,LoaiMonAn) VALUES(3,N'Thức Ăn Nhân Gian')");
            Sql("INSERT INTO CATEGORIES(ID,LoaiMonAn) VALUES(4,N'Thức Ăn Phổ Biến')");
        }
        
        public override void Down()
        {
        }
    }
}
