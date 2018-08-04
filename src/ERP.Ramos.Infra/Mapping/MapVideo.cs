using ERP.Ramos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Ramos.Infra.Mapping
{
    public class MapVideo : IEntityTypeConfiguration<Video>
    { 
        public void Configure(EntityTypeBuilder<Video> builder)
        {
        builder.ToTable("Video");
        //Foreikey
        builder.HasOne(x => x.UsuarioSugeriu).WithMany().HasForeignKey("IdUsuario");
        builder.HasOne(x => x.Canal).WithMany().HasForeignKey("IdCanal");
        builder.HasOne(x => x.PlayList).WithMany().HasForeignKey("IdPlayList");

        //Propriedades
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Titulo).HasMaxLength(200).IsRequired();
        builder.Property(x => x.Descricao).HasMaxLength(255).IsRequired();
        builder.Property(x => x.Tags).HasMaxLength(100).IsRequired();
        builder.Property(x => x.OrdenPlayList);
        //builder.Property(x => x.UrlLogo).HasMaxLength(200).IsRequired();
        builder.Property(x => x.idYouTube).HasMaxLength(50).IsRequired();
        builder.Property(x => x.Status).IsRequired();
    }
    }


}
        

