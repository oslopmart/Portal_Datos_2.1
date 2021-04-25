﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalDatos.BL 
{
    public class Contexto: DbContext
    {
        public Contexto() : base(@"Data Source=(LocalDb)\MSSQLLocalDB;AttachDBFilename=" +
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\ PotalDatosDB.mdf")
        {
                
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new DatosdeInicio()); //Agregar datos de inicio al momento de crear la base de datos
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet <Clientes> Clientes { get; set; }

        public DbSet <Orden> Ordenes { get; set; }
        public DbSet <OrdenDetalle> OrdenDetalle { get; set; }
        public DbSet <Usuario> Usuarios { get; set; }
    }
}
