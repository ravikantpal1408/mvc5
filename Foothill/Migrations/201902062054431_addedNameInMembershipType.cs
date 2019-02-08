namespace Foothill.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedNameInMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
