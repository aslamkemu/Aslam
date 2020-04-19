namespace Aslam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmigrationerrorupdate2 : DbMigration
    {
        public override void Up()
        {
           
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "DateofBirth", c => c.DateTime());
            DropColumn("dbo.Customers", "Birthdate");
        }
    }
}
