namespace WebApiData.Blog;
using WebApiDomain;

public interface IBlogRepository
{
    Task<Blogs> CreateBlog(Blogs blog);
    Task<Blogs> GetById(int id);
    Task<List<Blogs>> GetAllBlog();
    Task DeleteBlog(int id);
}
