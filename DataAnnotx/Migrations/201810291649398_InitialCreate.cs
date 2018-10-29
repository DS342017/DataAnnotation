namespace DataAnnotx.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pessoas",
                c => new
                    {
                        IdPessoa = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Cpf = c.String(),
                        RG = c.String(),
                        DataNascimento = c.String(),
                        Endereco = c.String(),
                        NumEnd = c.Int(nullable: false),
                        Bairro = c.String(),
                        Cidade = c.String(),
                        Estado = c.String(),
                        CEP = c.String(),
                        Detalhes = c.String(),
                    })
                .PrimaryKey(t => t.IdPessoa);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pessoas");
        }
    }
}
