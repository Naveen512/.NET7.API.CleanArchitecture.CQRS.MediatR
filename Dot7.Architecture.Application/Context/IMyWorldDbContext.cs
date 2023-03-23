using Microsoft.EntityFrameworkCore;

namespace Dot7.Architecture.Application.Context;

public interface IMyWorldDbContext
{
    DbSet<Dot7.Architecture.Domain.Entities.Beach> Beach{get;}

    Task<int> SaveToDbAsync();
}