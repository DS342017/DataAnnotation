namespace DataAnnotx.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotx6 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pessoas", "DataNascimento", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pessoas", "DataNascimento", c => c.String());
        }
    }
}
