namespace MinhasFinancas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificaoPadrao : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Movimentacaos", name: "Usuario_Id", newName: "UsuarioId");
            RenameIndex(table: "dbo.Movimentacaos", name: "IX_Usuario_Id", newName: "IX_UsuarioId");
            AddColumn("dbo.Movimentacaos", "Tipo", c => c.Int(nullable: false));
            DropColumn("dbo.Movimentacaos", "Tipoy");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movimentacaos", "Tipoy", c => c.Int(nullable: false));
            DropColumn("dbo.Movimentacaos", "Tipo");
            RenameIndex(table: "dbo.Movimentacaos", name: "IX_UsuarioId", newName: "IX_Usuario_Id");
            RenameColumn(table: "dbo.Movimentacaos", name: "UsuarioId", newName: "Usuario_Id");
        }
    }
}
