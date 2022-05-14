using DeeFyPlay.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DeeFyPlay.Infra.Configurations
{
    public class GeneroConfiguration : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).UseIdentityColumn();
            builder.Property(e => e.Nome).IsRequired().HasMaxLength(100);
            builder.Property(e => e.Descricao).IsRequired().HasMaxLength(100);

            builder.Property(e => e.DataInclusao).HasColumnType("datetime")
                .HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();



        }
    }
}

