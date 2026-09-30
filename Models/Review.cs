using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce_Api.Models;

public class Review
{
    public Guid Id { get; set; }

    [Required]
    public Guid ProductId { get; set; }

    [ForeignKey(nameof(ProductId))]
    public Product Product { get; set; } = null!;

    [Required]
    public Guid CustomerId { get; set; }

    [ForeignKey(nameof(CustomerId))]
    public Customer Customer { get; set; } = null!;

    [Range(1, 5)]
    public int Rating { get; set; }

    public string? Title { get; set; }

    public string? Body { get; set; }

    public bool IsVerifiedPurchase { get; set; }

    public DateTimeOffset CreatedAt { get; set; }
}