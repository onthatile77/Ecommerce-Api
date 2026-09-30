using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce_Api.Models;

public class ProductVariant
{
    public Guid Id { get; set; }

    [Required]
    public Guid ProductId { get; set; }

    [ForeignKey(nameof(ProductId))]
    public Product Product { get; set; } = null!;

    [Required]
    public string Sku { get; set; } = null!;

    [Required]
    public string Size { get; set; } = null!;

    [Required]
    public string Color { get; set; } = null!;

    [Range(0, double.MaxValue)]
    public decimal? PriceOverride { get; set; }

    [Range(0, double.MaxValue)]
    public decimal? SalePrice { get; set; }

    public bool IsActive { get; set; } = true;

    public ICollection<ProductImage> Images { get; set; } = new List<ProductImage>();

    public Inventory? Inventory { get; set; }

    public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

    public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public ICollection<WishlistItem> WishlistItems { get; set; } = new List<WishlistItem>();
}