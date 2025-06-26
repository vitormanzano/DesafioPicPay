using DesafioPicPay.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioPicPay.Data.Configurations
{
    public class TransferConfiguration : IEntityTypeConfiguration<Transfer>
    {
        public void Configure(EntityTypeBuilder<Transfer> builder)
        {
            builder.ToTable("Transfers");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Value)
                .IsRequired()
                .HasColumnType("DECIMAL(18,2)");

            builder
                .HasOne(p => p.Payer);

            builder
                .HasOne(p => p.Payee);
        }
    }
}
