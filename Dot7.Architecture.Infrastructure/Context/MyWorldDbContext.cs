using Dot7.Architecture.Application.Context;
using Dot7.Architecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dot7.Architecture.Infrastructure.Context;

public class MyWorldDbContext : DbContext, IMyWorldDbContext
{
    public MyWorldDbContext(DbContextOptions<MyWorldDbContext> options):base(options)
    {
        
    }
    public DbSet<Beach> Beach {get;set;}

    public async Task<int> SaveToDbAsync()
    {
        return await SaveChangesAsync();
    }
}