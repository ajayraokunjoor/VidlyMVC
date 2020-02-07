namespace Vidly_V2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingGenreIdDataToMovies : DbMigration
    {
        public override void Up()
        {
            Sql("Update Movies set GenreID = 5 where Id = 1");
            Sql("Update Movies set GenreID = 1 where Id = 2");
            Sql("Update Movies set GenreID = 1 where Id = 3");
            Sql("Update Movies set GenreID = 3 where Id = 4");
            Sql("Update Movies set GenreID = 4 where Id = 5");
        }

        public override void Down()
        {
        }
    }
}
