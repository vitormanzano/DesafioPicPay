using DesafioPicPay.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioPicPay.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.CompleteName).IsRequired().HasMaxLength(255);
            builder.Property(p => p.Password).IsRequired().HasMaxLength(255);
            builder.Property(p => p.UserType).HasConversion<string>().IsRequired().HasMaxLength(255);

            builder.HasIndex(p => p.Email)
                .IsUnique();

            builder.HasIndex(p => p.Cpf)
                .IsUnique();

            builder.HasMany(p => p.Transfers)
                .WithOne(p => p.Payer)
                .HasForeignKey(p => p.Id)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
