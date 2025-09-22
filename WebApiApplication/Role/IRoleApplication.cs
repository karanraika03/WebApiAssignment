using WebApiApplication.Role.DTO;

namespace WebApiApplication.Role;

public interface IRoleApplication
{
    Task<RoleDto> CreateRole(CreateUpdateRoleDto role);

    Task<RoleDto> GetById(int id);
    Task<List<RoleDto>> GetAllRoles();
    Task<string> DeleteRole(int id);
}
