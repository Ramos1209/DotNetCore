using ERP.Ramos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Ramos.Infra.Mapping
{
    public class MapPlayList : IEntityTypeConfiguration<PlayList>
    {
        public void Configure(EntityTypeBuilder<PlayList> builder)
        {
            builder.ToTable("PlayList");
            builder.HasOne(x => x.Usuario).WithMany().HasForeignKey("UsuarioId");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome)
                .HasMaxLength(50)
                .HasColumnName("Nome")
                .IsRequired();
        }
    }
}
