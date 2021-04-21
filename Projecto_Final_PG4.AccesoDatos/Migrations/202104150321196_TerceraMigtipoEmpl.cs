namespace Projecto_Final_PG4.AccesoDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TerceraMigtipoEmpl : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Personas", "tipo_empleado", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Personas", "tipo_empleado", c => c.String(maxLength: 1));
        }
    }
}
