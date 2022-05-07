using DeeFyPlay.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DeeFyPlay.Infra.Configurations
{
    public class AlbumConfiguration : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        { 
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).UseIdentityColumn();
            builder.Property(e => e.Titulo).IsRequired().HasMaxLength(100);

            builder.Property(e => e.DataInclusao).HasColumnType("datetime")
                .HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();



        }
    }
}


