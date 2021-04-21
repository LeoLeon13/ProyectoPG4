namespace Projecto_Final_PG4.AccesoDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SegundaMigced : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Servicios", "cedula", c => c.String(maxLength: 40));
            AddColumn("dbo.Servicios_Cliente", "cedula", c => c.String(maxLength: 40));
            DropColumn("dbo.Servicios", "ID_cliente");
            DropColumn("dbo.Servicios_Cliente", "ID_Cliente");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Servicios_Cliente", "ID_Cliente", c => c.String(maxLength: 30));
            AddColumn("dbo.Servicios", "ID_cliente", c => c.Int(nullable: false));
            DropColumn("dbo.Servicios_Cliente", "cedula");
            DropColumn("dbo.Servicios", "cedula");
        }
    }
}
