namespace FriendOrganizer.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddedRowVersionToFriend : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Friend", "RowVersion", c => c.Binary(false, fixedLength: true, timestamp: true, storeType: "rowversion"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Friend", "RowVersion");
        }
    }
}
