using FinalProject.Domain.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Domain.Entities;

public class User : Entity
{
    public int Id { get; set; }

    [StringLength(200)]
    public required string Login { get; set; }

    public required string Email { get; set; }
    [StringLength(200)]
    public required string PasswordHash { get; set; }

    [StringLength(300)]
    public required string Role { get; set; }
}
