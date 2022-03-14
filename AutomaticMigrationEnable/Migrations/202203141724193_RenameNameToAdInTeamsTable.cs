namespace AutomaticMigrationEnable.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameNameToAdInTeamsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "Ad", c => c.String());
            Sql("Update Teams set Ad=Name");
            DropColumn("dbo.Teams", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teams", "Name", c => c.String());
            Sql("Update Teams set Name=Ad");
            DropColumn("dbo.Teams", "Ad");
        }
    }
}
