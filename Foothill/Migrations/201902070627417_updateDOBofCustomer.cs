namespace Foothill.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDOBofCustomer : DbMigration
    {
        public override void Up()
        {

            Sql("UPDATE Customers SET BirthDate='1988-08-14' WHERE Id=1");
        }
        
        public override void Down()
        {
        }
    }
}
