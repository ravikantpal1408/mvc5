namespace Foothill.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedNullableFromCreatedDateFromCinemas : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cinemas", "CreatedDt", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cinemas", "CreatedDt", c => c.DateTime(nullable: false));
        }
    }
}
