namespace Vidly_V2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBirthDateToCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("Update Customers Set BirthDate = '1/1/1980' where Id = 1");
            Sql("Update Customers Set BirthDate = '' where Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
