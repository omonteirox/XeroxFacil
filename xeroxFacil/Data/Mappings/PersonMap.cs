using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xeroxFacil.Models;

namespace xeroxFacil.Data.Mappings
{
    public class PersonMap : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Person");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Email).IsRequired().HasMaxLength(120).HasColumnType("varchar(120)");
            builder.Property(x => x.Name).IsRequired().HasMaxLength(120).HasColumnType("varchar(120)");
        }
    }
}

//public string Email { get; private set; } = string.Empty;
//public string Name { get; private set; } = string.Empty;
//public List<Xerox> Xeroxs { get; private set; } = null;
//public List<HomeWork> HomeWorks { get; private set; } = null;