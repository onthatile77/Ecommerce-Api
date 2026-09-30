using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce_Api.Models;

public class Inventory
{
    public Guid Id { get; set; }

    [Required]
    public Guid ProductVariantId { get; set; }

    [ForeignKey(nameof(ProductVariantId))]
    public ProductVariant ProductVariant { get; set; } = null!;

    [Range(0, int.MaxValue)]
    public int QuantityOnHand { get; set; }

    [Range(0, int.MaxValue)]
    public int QuantityReserved { get; set; }

    [Range(0, int.MaxValue)]
    public int LowStockThreshold { get; set; }
}