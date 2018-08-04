using ERP.Ramos.Domain.Entities;
using ERP.Ramos.Domain.ValueObjects;
using ERP.Ramos.Infra.Mapping;
using ERP.Ramos.Shared;
using Microsoft.EntityFrameworkCore;
using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Ramos.Infra.Context
{
   public class RamosContext:DbContext
    {
        public RamosContext()
        {

        }

        public DbSet<Canal> Canal { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<PlayList> PlayLists { get; set; }
        // public DbSet<Favorito> Favoritos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Settings.ConnectionString);
           // base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Nome>();
            modelBuilder.Ignore<Email>();
            modelBuilder.Ignore<Notification>();

            modelBuilder.ApplyConfiguration(new MapUsuario());
            modelBuilder.ApplyConfiguration(new MapPlayList());
            base.OnModelCreating(modelBuilder);
        }
    }
}
