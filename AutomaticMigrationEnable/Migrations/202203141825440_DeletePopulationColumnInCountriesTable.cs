namespace AutomaticMigrationEnable.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletePopulationColumnInCountriesTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Countries", "Population");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Countries", "Population", c => c.Int(nullable: false));
        }
    }
}
