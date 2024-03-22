using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ContactosRest.Models;
using Microsoft.Extensions.Configuration;

namespace ContactManagerAPI.Data
{
    public partial class contextoDb : Microsoft.EntityFrameworkCore.DbContext
    {
        public contextoDb(DbContextOptions<contextoDb> options) : base(options)
        {
        }

        public DbSet<Contacto> Contacts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contacto>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("contactos");

                entity.Property(e=> e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre).HasColumnName("nombre");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Telefono).HasColumnName("telefono");

                entity.Property(e => e.Direccion).HasColumnName("direccion");
                entity.Property(e => e.Company).HasColumnName("company");
                entity.Property(e => e.Nota).HasColumnName("nota");

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}