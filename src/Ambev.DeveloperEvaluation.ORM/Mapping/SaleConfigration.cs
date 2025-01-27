using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ambev.DeveloperEvaluation.ORM.Mapping;

public class SaleConfiguration : IEntityTypeConfiguration<Sale>
{
    public void Configure(EntityTypeBuilder<Sale> builder)
    {
        builder.ToTable("Sales");

        builder.HasKey(s => s.SaleId);

        builder.Property(s => s.SaleId)
            .ValueGeneratedOnAdd();

        builder.Property(s => s.SaleNumber)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(s => s.SaleDate)
            .IsRequired()
            .HasDefaultValueSql("GETDATE()");

        builder.Property(s => s.TotalSaleAmount)
            .IsRequired()
            .HasColumnType("decimal(18,2)");

        builder.Property(s => s.Branch)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(s => s.Products)
            .IsRequired();

        builder.Property(s => s.Quantities)
            .IsRequired();

        builder.Property(s => s.UnitPrices)
            .IsRequired();

        builder.Property(s => s.Discounts)
            .IsRequired();

        builder.Property(s => s.TotalAmountForEachItem)
            .IsRequired();

        builder.Property(s => s.IsCancelled)
            .IsRequired()
            .HasDefaultValue(false);

        builder.HasOne(s => s.Customer)
            .WithMany()
            .HasForeignKey(s => s.CustomerId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
