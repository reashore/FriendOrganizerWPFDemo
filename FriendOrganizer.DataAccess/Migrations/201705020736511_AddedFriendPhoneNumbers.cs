namespace FriendOrganizer.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddedFriendPhoneNumbers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FriendPhoneNumber",
                c => new
                    {
                        Id = c.Int(false, true),
                        Number = c.String(false),
                        FriendId = c.Int(false)
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Friend", t => t.FriendId, true)
                .Index(t => t.FriendId);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FriendPhoneNumber", "FriendId", "dbo.Friend");
            DropIndex("dbo.FriendPhoneNumber", new[] { "FriendId" });
            DropTable("dbo.FriendPhoneNumber");
        }
    }
}
