namespace WeBookNewUpdate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Descrebtion", c => c.String());
            AddColumn("dbo.Books", "Phone", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Phone");
            DropColumn("dbo.Books", "Descrebtion");
        }
    }
}
