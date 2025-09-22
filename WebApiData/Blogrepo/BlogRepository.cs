﻿using Microsoft.EntityFrameworkCore;
namespace WebApiData.Blog;
using WebApiDomain;

public class BlogRepository : IBlogRepository
{
    private readonly DataContext _context;

    public BlogRepository(DataContext context)
    {
        _context = context;
    }

    public async Task<Blog> CreateBlog(Blog blog)
    {
        _context.Blogs.Add(blog);
        await _context.SaveChangesAsync();
        return blog;
    }

    public async Task DeleteBlog(int id)
    {

        var blog = await _context.Blogs.FindAsync(id);
        _context.Blogs.Remove(blog);
    }

    public async Task<List<Blog>> GetAllBlog()
    {
        return await _context.Blogs.ToListAsync();
    }

    public async Task<Blog> GetById(int id)
    {
        return await _context.Blogs.FindAsync();
    }
}
