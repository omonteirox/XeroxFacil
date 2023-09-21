using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xeroxFacil.Models;

namespace xeroxFacil.Data.Mappings
{
    public class HomeWorkMap : IEntityTypeConfiguration<HomeWork>
    {
        public void Configure(EntityTypeBuilder<HomeWork> builder)
        {
            builder.ToTable("HomeWork");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.InitialDate).IsRequired().HasColumnType("DATETIME");
            builder.Property(x => x.FinalDate).HasColumnType("DATETIME");
            builder.Property(x => x.isDone).IsRequired().HasColumnType("BIT");
            builder.Property(x => x.TotalValue).IsRequired().HasColumnType("DECIMAL(10,2)");
            builder.Property(x => x.TotalPaid).IsRequired().HasColumnType("DECIMAL(10,2)");
            builder.Property(x => x.Description).IsRequired().HasMaxLength(120).HasColumnType("varchar(120)");
            builder.Property(x => x.ClientCode).IsRequired().HasMaxLength(6).HasColumnType("varchar(6)");

            builder.HasOne(x => x.Person).WithMany(x => x.HomeWorks).HasConstraintName("FK_HomeWork_Person").OnDelete(DeleteBehavior.Restrict);
        }
    }
}