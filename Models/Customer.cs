using System.ComponentModel.DataAnnotations;

namespace Ecommerce_Api.Models;

public class Customer
{
    public Guid Id { get; set; }

    [Required, EmailAddress]
    public string Email { get; set; } = null!;

    [Required]
    public string FirstName { get; set; } = null!;

    [Required]
    public string LastName { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public DateTimeOffset CreatedAt { get; set; }

    public ICollection<Address> Addresses { get; set; } = new List<Address>();

    public ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public ICollection<Order> Orders { get; set; } = new List<Order>();

    public ICollection<Review> Reviews { get; set; } = new List<Review>();

    public ICollection<WishlistItem> WishlistItems { get; set; } = new List<WishlistItem>();
}