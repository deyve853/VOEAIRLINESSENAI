using VoeAirlinesSenai.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VoeAirlinesSenai.EntityConfigurations;

public class AeronaveConfiguration : IEntityTypeConfiguration<Aeronave>
{

    public void Configure(EntityTypeBuilder<Aeronave> builder)
    {
        builder.ToTable("Aeronave");
        builder.HasKey(a => a.Id);
        builder.Property(a => a.Fabricante)
             .IsRequired()
             .HasMaxLength(50);
        builder.Property(a => a.Modelo)
        .IsRequired()
        .HasMaxLength(50);
        builder.Property(a => a.Codigo)
        .IsRequired()
        .HasMaxLength(10);
        //relacionamento
        //Many one
        builder.HasMany(a => a.Manutencoes)
             .WithOne(m => m.Aeronave)
             .HasForeignKey(m => m.AeronaveId);
    }
}