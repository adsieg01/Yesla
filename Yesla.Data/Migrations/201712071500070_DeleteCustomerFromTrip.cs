namespace Yesla.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteCustomerFromTrip : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Trip", "CustomerID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Trip", "CustomerID", c => c.Int(nullable: false));
        }
    }
}
