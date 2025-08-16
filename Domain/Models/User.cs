using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bankstan_payment.Domain.Models;

/// <summary>
/// User personal information and login credentials
/// </summary>
public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public Guid Uuid { get; set; } = Guid.NewGuid();

    [Required] public string FirstName { get; set; } = string.Empty;

    [Required] public string MiddleName { get; set; } = string.Empty;

    [Required] public string LastName { get; set; } = string.Empty;

    [Required] [EmailAddress] public string Email { get; set; } = string.Empty;

    public string ProfilePicture { get; set; } = string.Empty;

    public Gender Gender { get; set; }


    public DateTime BirthDate { get; set; }

    [Phone] public string Phone { get; set; } = string.Empty;

    [Required] public string PasswordHash { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    [InverseProperty("User")] public ICollection<Account> Accounts { get; set; } = new List<Account>();
}

public enum Gender
{
    Male,
    Female
}