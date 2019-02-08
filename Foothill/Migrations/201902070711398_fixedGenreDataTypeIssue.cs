namespace Foothill.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixedGenreDataTypeIssue : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cinemas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Month = c.String(),
                        Day = c.String(),
                        Year = c.String(),
                        InStock = c.Short(nullable: false),
                        CreatedDt = c.DateTime(),
                        GenreId = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
                .Index(t => t.GenreId);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Short(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            
        }
        
        public override void Down()
        {
           
        }
    }
}
