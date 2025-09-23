using Microsoft.EntityFrameworkCore;
using WebApiDomain;

namespace WebApiData;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    public DbSet<Role> Roles { get; set; }

    public DbSet<Employee> Employees { get; set; }

    public DbSet<WebApiDomain.Blogs> Blogs { get; set; }

    public DbSet<ResetPasswordCode> ResetPasswordCodes { get; set; }
}
