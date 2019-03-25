using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WitStyle.Data.Entities;

namespace WitStyle.Data.Configurations
{
    public class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.ToTable("Menu")
                .HasKey(x => x.MenuId);

            builder.Property(x => x.MenuId)
                .IsRequired()
                .HasColumnName("MenuId");

            builder.Property(x => x.MenuType)
                .IsRequired()
                .HasMaxLength(45)
                .HasColumnName("MenuType");
        }
    }
}
