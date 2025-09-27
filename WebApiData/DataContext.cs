using Microsoft.EntityFrameworkCore;
using WebApiDomain;

 

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    public DbSet<Role> Roles { get; set; }

    public DbSet<Employee> Employees { get; set; }

    public DbSet<Blog> Blogs { get; set; }

    public DbSet<ResetPasswordCode> ResetPasswordCodes { get; set; }
}
