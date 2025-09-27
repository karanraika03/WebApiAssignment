namespace WebApiApplication.Blog.DTO;

public interface IBlogApplication
{
    Task<BlogDto> CreateBlog(CreateUpdateBlogDto blog);

    Task<BlogDto> GetById(int id);
    Task<List<BlogDto>> GetAllBlogs();
    Task<string> DeleteBlog(int id);
}
