namespace AV2_WyllerMachado.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PedidoFix : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pedidos", "Status", c => c.String(maxLength: 64));
            AlterColumn("dbo.Pedidos", "DataPedido", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pedidos", "DataPedido", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Pedidos", "Status", c => c.String());
        }
    }
}
