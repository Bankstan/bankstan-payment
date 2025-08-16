using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bankstan_payment.Domain.Models;

/// <summary>
/// User financial account information
/// </summary>
public class Account
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string AccountNumber { get; set; } = string.Empty;

    [Required]
    [Range(0.00, double.MaxValue, ErrorMessage = "Balance must be a positive number.")]
    public decimal Balance { get; set; }

    public string Currency { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;


    [ForeignKey("User")] public int UserId { get; set; }


    public User User { get; set; } = null!;
}