using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xeroxFacil.Models;

namespace xeroxFacil.Data.Mappings
{
    public class XeroxMap : IEntityTypeConfiguration<Xerox>
    {
        public void Configure(EntityTypeBuilder<Xerox> builder)
        {
            builder.ToTable("Xerox");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.InitialDate).IsRequired().HasColumnType("DATETIME");
            builder.Property(x => x.FinalDate).HasColumnType("DATETIME");
            builder.Property(x => x.isDone).IsRequired().HasColumnType("BIT");
            builder.Property(x => x.TotalValue).IsRequired().HasColumnType("DECIMAL(10,2)");
            builder.Property(x => x.TotalPaid).IsRequired().HasColumnType("DECIMAL(10,2)");
            builder.Property(x => x.Description).IsRequired().HasMaxLength(120).HasColumnType("varchar(120)");
            builder.Property(x => x.AmountOfPages).IsRequired().HasColumnType("INT").HasMaxLength(4);
            builder.Property(x => x.isColorful).IsRequired().HasColumnType("BIT");
            builder.Property(x => x.ClientCode).IsRequired().HasMaxLength(6).HasColumnType("varchar(6)");

            builder.HasOne(x => x.Person).WithMany(x => x.Xeroxs).HasConstraintName("FK_Xerox_Person").OnDelete(DeleteBehavior.Restrict);
        }
    }
}