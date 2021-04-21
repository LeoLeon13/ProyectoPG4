namespace Projecto_Final_PG4.AccesoDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PrimerMig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Auto_Cliente",
                c => new
                    {
                        ID_Auto_Cliente = c.Int(nullable: false, identity: true),
                        cedula = c.String(maxLength: 15),
                        placa = c.String(maxLength: 7),
                    })
                .PrimaryKey(t => t.ID_Auto_Cliente);
            
            CreateTable(
                "dbo.Automotores",
                c => new
                    {
                        ID_automotor = c.Int(nullable: false, identity: true),
                        placa = c.String(maxLength: 6),
                        marca = c.String(maxLength: 50),
                        modelo = c.String(maxLength: 50),
                        tipo_combustible = c.String(maxLength: 30),
                        cilindraje = c.Int(nullable: false),
                        tipo_vehiculo = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID_automotor);
            
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        cedula = c.String(nullable: false, maxLength: 128),
                        password = c.String(maxLength: 10),
                        perfil = c.String(maxLength: 1),
                    })
                .PrimaryKey(t => t.cedula);
            
            CreateTable(
                "dbo.Personas",
                c => new
                    {
                        cedula = c.String(nullable: false, maxLength: 128),
                        ID_persona = c.Int(nullable: false),
                        nombre = c.String(maxLength: 50),
                        apellido = c.String(maxLength: 50),
                        correo = c.String(maxLength: 50),
                        celular = c.Int(nullable: false),
                        esEmpleado = c.String(maxLength: 1),
                        telefono = c.Int(nullable: false),
                        direccion = c.String(maxLength: 80),
                        tipo_empleado = c.String(maxLength: 1),
                        departamento = c.String(maxLength: 50),
                        pass = c.String(maxLength: 16),
                    })
                .PrimaryKey(t => t.cedula);
            
            CreateTable(
                "dbo.Servicios",
                c => new
                    {
                        ID_servicio = c.Int(nullable: false, identity: true),
                        ID_tipo_servicio = c.Int(nullable: false),
                        fecha = c.DateTime(nullable: false),
                        descripcion_servicio = c.String(maxLength: 120),
                        ID_cliente = c.Int(nullable: false),
                        placa = c.String(maxLength: 6),
                        servicio_seleccionado = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID_servicio);
            
            CreateTable(
                "dbo.Servicios_Cliente",
                c => new
                    {
                        ID_Servicio_Cliente = c.Int(nullable: false, identity: true),
                        ID_Cliente = c.String(maxLength: 30),
                        placa = c.String(maxLength: 7),
                        Servicio_Seleccionado = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID_Servicio_Cliente);
            
            CreateTable(
                "dbo.TipoServicios",
                c => new
                    {
                        ID_tipo_servicio = c.Int(nullable: false, identity: true),
                        descripcion_servicio = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID_tipo_servicio);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TipoServicios");
            DropTable("dbo.Servicios_Cliente");
            DropTable("dbo.Servicios");
            DropTable("dbo.Personas");
            DropTable("dbo.Logins");
            DropTable("dbo.Automotores");
            DropTable("dbo.Auto_Cliente");
        }
    }
}
