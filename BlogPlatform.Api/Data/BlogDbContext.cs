using BlogPlatform.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogPlatform.Api.Data;

public class BlogDbContext : DbContext
{
    public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options) { }

    public DbSet<Post> Posts => Set<Post>();
}