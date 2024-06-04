using FinalProject.Domain.Enums;

namespace FinalProject.Application.Contracts
{
    public record UserGetDto
    {
        public int Id { get; set; }
        public string? Login { get; set; }
        public Roles Role { get; set; }
    }
}
