namespace Foothill.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedCreatedDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cinemas", "CreatedDt", c => c.DateTime(nullable: false,defaultValue: DateTime.UtcNow));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cinemas", "CreatedDt");
        }
    }
}
