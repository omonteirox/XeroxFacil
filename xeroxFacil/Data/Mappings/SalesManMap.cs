using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xeroxFacil.Models;

namespace xeroxFacil.Data.Mappings
{
    public class SalesManMap : IEntityTypeConfiguration<Salesman>
    {
        public void Configure(EntityTypeBuilder<Salesman> builder)
        {
            builder.ToTable("Salesman");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(120).HasColumnType("varchar(120)");
            builder.Property(x => x.Email).IsRequired().HasMaxLength(120).HasColumnType("varchar(120)");
            builder.Property(x => x.Password).IsRequired().HasMaxLength(120).HasColumnType("varchar(120)");
        }
    }
}