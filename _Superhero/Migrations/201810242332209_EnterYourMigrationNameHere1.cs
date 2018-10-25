namespace _Superhero.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EnterYourMigrationNameHere1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "alterEgo", c => c.String());
            AddColumn("dbo.People", "primeryAbility", c => c.String());
            AddColumn("dbo.People", "secondaryAbility", c => c.String());
            AddColumn("dbo.People", "catchphrase", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "catchphrase");
            DropColumn("dbo.People", "secondaryAbility");
            DropColumn("dbo.People", "primeryAbility");
            DropColumn("dbo.People", "alterEgo");
        }
    }
}
