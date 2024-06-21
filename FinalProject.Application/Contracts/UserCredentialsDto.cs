using System.ComponentModel.DataAnnotations;

namespace SpotiPie.Application.Contracts;

public record UserCredentialsDto
{


    [Required(AllowEmptyStrings = false)]
    public string? Login { get; set; }

    [Required(AllowEmptyStrings = false)]
    [StringLength(200, MinimumLength = 4)]
    public string? Password { get; init; }
}
