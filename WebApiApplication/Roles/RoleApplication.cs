﻿using WebApiApplication.Role;
using WebApiApplication.Role.DTO;
using WebApiData.RoleRepo;
using WebApiDomain;

namespace Application.Roles;

public class RoleApplication : IRoleApplication
{
    private readonly IRoleRepository _roleRepository;

    public RoleApplication(IRoleRepository roleRepository)
    {
        _roleRepository = roleRepository;
    }

    public async Task<Role> AddRole(CreateUpdateRoleDto input)
    {
        var role = new Role
        {
            Name = input.Name,
            CreatedDate = DateTime.Now,
        };

        return await _roleRepository.CreateRole(role);
    }

    public async Task<Role> UpdateRole(int id, CreateUpdateRoleDto input)
    {
        var role = new Role
        {
            Name = input.Name,
        };

        return await _roleRepository.UpdateRole(id, role);
    }
    public async Task<List<RoleDto>> GetAllRoles()
    {
        var roles = await _roleRepository.GetAllRoles();

        var mapData = roles.Select(x => new RoleDto
        {
            Id = x.Id,
            Name = x.Name,
            CreatedDate = DateTime.Now,
        }).ToList();

        return mapData;
    }


    public async Task DeleteRole(int id)
    {
        await _roleRepository.DeleteRole(id);
    }
}
