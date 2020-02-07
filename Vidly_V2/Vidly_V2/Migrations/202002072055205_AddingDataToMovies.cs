namespace Vidly_V2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingDataToMovies : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Movies values ('Hangover', 'Comedy', '1/1/1990', '1/6/1990', 10)");
            Sql("Insert into Movies values ('Die Hard', 'Action', '1/1/1991', '1/6/1991', 2)");
            Sql("Insert into Movies values ('The Terminator', 'Action', '1/1/1992', '1/6/1992', 7)");
            Sql("Insert into Movies values ('Toy Story', 'Family', '1/1/1992', '1/6/1993', 6)");
            Sql("Insert into Movies values ('Titanic', 'Romance', '1/1/1994', '1/6/1994', 5)");
        }
        
        public override void Down()
        {
        }
    }
}
