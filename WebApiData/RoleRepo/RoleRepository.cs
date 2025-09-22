using WebApiDomain;

namespace WebApiData.RoleRepo;

public class RoleRepository : IRoleRepository
{
    private readonly DataContext _context;
    public RoleRepository(DataContext context)
    {
        _context = context;
    }
    public async Task<Role> GetById(int id)
    {
        return await _context.Roles.FindAsync(id);
    }
}
