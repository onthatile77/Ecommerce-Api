using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce_Api.Models;

public class Order
{
    public Guid Id { get; set; }

    [Required]
    public string OrderNumber { get; set; } = null!;

    [Required]
    public Guid CustomerId { get; set; }

    [ForeignKey(nameof(CustomerId))]
    public Customer Customer { get; set; } = null!;

    [Required]
    public OrderStatus Status { get; set; }

    [Required]
    public Guid ShippingAddressId { get; set; }

    [ForeignKey(nameof(ShippingAddressId))]
    public Address ShippingAddress { get; set; } = null!;

    [Range(0, double.MaxValue)]
    public decimal Subtotal { get; set; }

    [Range(0, double.MaxValue)]
    public decimal ShippingCost { get; set; }

    [Range(0, double.MaxValue)]
    public decimal Tax { get; set; }

    [Range(0, double.MaxValue)]
    public decimal Total { get; set; }

    public DateTimeOffset PlacedAt { get; set; }

    public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();

    public ICollection<Payment> Payments { get; set; } = new List<Payment>();
}