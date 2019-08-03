using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Nome).HasMaxLength(400).IsRequired();
            builder.Property(c => c.SobreNome).HasMaxLength(400).IsRequired();
            builder.Property(c => c.Email).HasMaxLength(400).IsRequired();
            builder.Property(c => c.Senha).HasMaxLength(400).IsRequired();
            builder.Property(c => c.Sexo).IsRequired();
            builder.Property(c => c.UrlFoto).HasMaxLength(400).IsRequired();
            builder.Property(c => c.DataNascimento).IsRequired();
            builder.HasOne(c => c.Identificacao)
                .WithOne(c => c.Usuario)
                .HasForeignKey<Identificacao>(c => c.UsuarioId);
            builder.HasMany(c => c.Postagens).WithOne(c => c.Usuario).HasForeignKey(c => c.UsuarioId);
        }
    }
}
