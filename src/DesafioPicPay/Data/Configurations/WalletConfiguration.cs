using DesafioPicPay.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioPicPay.Data.Configurations
{
    public class WalletConfiguration : IEntityTypeConfiguration<Wallet>
    {
        public void Configure(EntityTypeBuilder<Wallet> builder)
        {
            builder.ToTable("Wallets");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.AccountBalance)
                .IsRequired()
                .HasColumnType("DECIMAL(18,2)");

            builder.HasOne(p => p.User);
        }
    }
}
