namespace Aslam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class errorupdate : DbMigration
    {
        public override void Up()
        {
           
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String());
        }
    }
}
