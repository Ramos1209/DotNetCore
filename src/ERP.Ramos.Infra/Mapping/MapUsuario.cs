using ERP.Ramos.Domain.Entities;
using ERP.Ramos.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Ramos.Infra.Mapping
{
    public class MapUsuario : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(x => x.Id);

            builder.OwnsOne<Nome>(x => x.Nome, cb =>
            {
                cb.Property(x => x.PrimeiroNome)
                                    .HasColumnName("PrimeiroNome")
                                    .HasColumnType("varchar")
                                    .HasMaxLength(50)
                                    .IsRequired();

                cb.Property(x => x.UltimoNome)
               .HasColumnName("UltimoNome")
               .HasColumnType("varchar")
               .HasMaxLength(50);
            });


            builder.OwnsOne<Email>(x => x.Email, cb =>
            {
                cb.Property(x => x.Endereco)
                                    .HasColumnName("Email")
                                    .HasColumnType("varchar")
                                    .HasMaxLength(150)
                                    .IsRequired();
            });
        }
    }
  }
