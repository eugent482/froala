namespace SiteProduct.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addloaddatetophototable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblProductDescriptionImages", "LoadDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblProductDescriptionImages", "LoadDate");
        }
    }
}
