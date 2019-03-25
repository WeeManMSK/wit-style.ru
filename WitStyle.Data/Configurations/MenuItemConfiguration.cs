using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WitStyle.Data.Entities;

namespace WitStyle.Data.Configurations
{
    public class MenuItemConfiguration : IEntityTypeConfiguration<MenuItem>
    {
        public void Configure(EntityTypeBuilder<MenuItem> builder)
        {
            builder.ToTable("MenuItem")
                .HasKey(x => x.MenuItemId);

            builder.Property(x => x.MenuItemId)
                .IsRequired()
                .HasColumnName("MenuItemId");

            builder.Property(x => x.MenuId)
                .IsRequired()
                .HasColumnName("MenuId");

            builder.Property(x => x.DisplayName)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("DisplayName");

            builder.Property(x => x.ControllerName)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("ControllerName");

            builder.Property(x => x.ActionName)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("ActionName");

            builder.Property(x => x.ParentMenuItemId)
                .HasColumnName("ParentMenuItemId");

            builder.HasOne(x => x.ParentMenuItem)
                .WithMany(x => x.Children)
                .HasForeignKey(x => x.ParentMenuItemId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Menu)
                .WithMany(x => x.MenuItems)
                .HasForeignKey(x => x.MenuId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
