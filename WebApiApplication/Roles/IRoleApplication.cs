using WebApiApplication.Role.DTO;
using WebApiDomain;


public interface IRoleApplication
{
    Task<Role> AddRole(CreateUpdateRoleDto input);

    Task<Role> UpdateRole(int id, CreateUpdateRoleDto input);
    Task DeleteRole(int id);
    Task<List<RoleDto>> GetAllRoles();
}
