namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveIEnumerable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "SelectedGenre");
            DropColumn("dbo.Movies", "SelectedRating");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "SelectedRating", c => c.String());
            AddColumn("dbo.Movies", "SelectedGenre", c => c.String());
        }
    }
}
