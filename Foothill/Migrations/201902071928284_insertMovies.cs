namespace Foothill.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class insertMovies : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO Cinemas (Name,Month,Day,Year,InStock,GenreId) VALUES('Titanic','Dec','12','1997',7,1)");
            Sql("INSERT INTO Cinemas (Name,Month,Day,Year,InStock,GenreId) VALUES('Ring','August','14','2005',2,2)");
            Sql("INSERT INTO Cinemas (Name,Month,Day,Year,InStock,GenreId) VALUES('Die Hard','Sept','10','1988',7,3)");
            Sql("INSERT INTO Cinemas (Name,Month,Day,Year,InStock,GenreId) VALUES('Euro Trip','Nov','19','1999',7,5)");
        }
        
        public override void Down()
        {
        }
    }
}
