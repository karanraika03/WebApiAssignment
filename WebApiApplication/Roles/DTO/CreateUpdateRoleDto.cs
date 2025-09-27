using System.ComponentModel.DataAnnotations;

namespace WebApiApplication.Role.DTO;

public class CreateUpdateRoleDto
{
    [Required(ErrorMessage = "Name is required!")]
    public string Name { get; set; }
}
