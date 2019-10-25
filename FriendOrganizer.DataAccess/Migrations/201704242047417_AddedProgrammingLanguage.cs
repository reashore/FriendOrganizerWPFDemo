namespace FriendOrganizer.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddedProgrammingLanguage : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProgrammingLanguage",
                c => new
                    {
                        Id = c.Int(false, true),
                        Name = c.String(false, 50)
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Friend", "FavoriteLanguageId", c => c.Int());
            CreateIndex("dbo.Friend", "FavoriteLanguageId");
            AddForeignKey("dbo.Friend", "FavoriteLanguageId", "dbo.ProgrammingLanguage", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Friend", "FavoriteLanguageId", "dbo.ProgrammingLanguage");
            DropIndex("dbo.Friend", new[] { "FavoriteLanguageId" });
            DropColumn("dbo.Friend", "FavoriteLanguageId");
            DropTable("dbo.ProgrammingLanguage");
        }
    }
}
