namespace Vidly_V2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into MembershipTypes (Id, SignupFee, DurationInMonths, DiscountRate) Values (1, 0, 0, 0)");
            Sql("Insert into MembershipTypes (Id, SignupFee, DurationInMonths, DiscountRate) Values (2, 30, 0, 10)");
            Sql("Insert into MembershipTypes (Id, SignupFee, DurationInMonths, DiscountRate) Values (3, 90, 3, 15)");
            Sql("Insert into MembershipTypes (Id, SignupFee, DurationInMonths, DiscountRate) Values (4, 300, 12, 20)");
             

        }
        
        public override void Down()
        {
        }
    }
}