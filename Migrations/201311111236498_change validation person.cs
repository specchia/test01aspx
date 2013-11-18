namespace MvcApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changevalidationperson : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "First", c => c.String(nullable: false));
            AlterColumn("dbo.People", "LastName", c => c.String(nullable: false, maxLength: 15));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "LastName", c => c.String());
            AlterColumn("dbo.People", "First", c => c.String());
        }
    }
}
