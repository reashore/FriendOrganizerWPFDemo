namespace FriendOrganizer.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Friend",
                c => new
                    {
                        Id = c.Int(false, true),
                        FirstName = c.String(false, 50),
                        LastName = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50)
                    })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            DropTable("dbo.Friend");
        }
    }
}
