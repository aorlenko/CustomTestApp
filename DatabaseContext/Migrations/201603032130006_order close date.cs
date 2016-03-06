namespace DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class orderclosedate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "CloseDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "CloseDate");
        }
    }
}
