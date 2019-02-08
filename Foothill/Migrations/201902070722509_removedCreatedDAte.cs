namespace Foothill.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedCreatedDAte : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Cinemas", "CreatedDt");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cinemas", "CreatedDt", c => c.DateTime());
        }
    }
}
