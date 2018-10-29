namespace DataAnnotx.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotx : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pessoas", "Nome", c => c.String());
            AlterColumn("dbo.Pessoas", "Cpf", c => c.String());
            AlterColumn("dbo.Pessoas", "DataNascimento", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pessoas", "DataNascimento", c => c.String(nullable: false));
            AlterColumn("dbo.Pessoas", "Cpf", c => c.String(maxLength: 14));
            AlterColumn("dbo.Pessoas", "Nome", c => c.String(nullable: false));
        }
    }
}
