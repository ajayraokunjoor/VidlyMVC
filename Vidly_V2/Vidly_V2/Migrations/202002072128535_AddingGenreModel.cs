namespace Vidly_V2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingGenreModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Movies", "Genre", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Genre", c => c.String());
            AlterColumn("dbo.Movies", "Name", c => c.String());
        }
    }
}