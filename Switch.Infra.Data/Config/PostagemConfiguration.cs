using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class PostagemConfiguration : IEntityTypeConfiguration<Postagem>
    {
        public void Configure(EntityTypeBuilder<Postagem> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.DataPublicacao).IsRequired();
            builder.Property(c => c.Texto).HasMaxLength(500).IsRequired();
        }
    }
}