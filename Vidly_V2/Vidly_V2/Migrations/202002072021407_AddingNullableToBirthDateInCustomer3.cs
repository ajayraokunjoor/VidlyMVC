namespace Vidly_V2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingNullableToBirthDateInCustomer3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "BirthDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "BirthDate", c => c.DateTime(nullable: false));
        }
    }
}
