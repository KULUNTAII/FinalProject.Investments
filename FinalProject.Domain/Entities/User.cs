using FinalProject.Domain.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Domain.Entities;

public class User : Entity
{
    [StringLength(200)]
    public required string Login { get; set; }

    [StringLength(200)]
    public required string PasswordHash { get; set; }
    public required string Role { get; set; }
    public Participant? Participant { get; set; }
    public Investor? Investor { get; set; }
}
