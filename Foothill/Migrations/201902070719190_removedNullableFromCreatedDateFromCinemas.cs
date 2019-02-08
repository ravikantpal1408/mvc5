namespace Foothill.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedNullableFromCreatedDateFromCinemas : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cinemas", "CreatedDt", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cinemas", "CreatedDt", c => c.DateTime());
        }
    }
}
