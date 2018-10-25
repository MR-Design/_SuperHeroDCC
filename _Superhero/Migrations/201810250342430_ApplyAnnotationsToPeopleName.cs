namespace _Superhero.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationsToPeopleName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "Name", c => c.String());
        }
    }
}
