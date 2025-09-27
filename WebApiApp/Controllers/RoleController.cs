using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiApplication.Role;
using WebApiApplication.Role.DTO;

namespace WebApiApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RoleController : ControllerBase
{
    private readonly IRoleApplication _roleApplication;

    public RoleController(IRoleApplication roleApplication)
    {
        _roleApplication = roleApplication;
    }

    [HttpGet]
    public async Task<List<RoleDto>> GetAllRoles()
    {
        return await _roleApplication.GetAllRoles();
    }

    [HttpPost]
    public async Task<IActionResult> CreateRole(CreateUpdateRoleDto role)
    {
        var result = await _roleApplication.AddRole(role);
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateRole(int id, CreateUpdateRoleDto input)
    {
        var result = await _roleApplication.UpdateRole(id, input);
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteRole(int id)
    {
        await _roleApplication.DeleteRole(id);
        return Ok("Role deleted successfully!");
    }
}
