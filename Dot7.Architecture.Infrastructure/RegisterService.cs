using Dot7.Architecture.Application.Context;
using Dot7.Architecture.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Dot7.Architecture.Infrastructure;

public static class RegisterService
{
    public static void ConfigureInfraStructure(this IServiceCollection services,
    IConfiguration configuration)
    {
        services.AddDbContext<MyWorldDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("MyWorldDbConnection"));
        });

        services.AddScoped<IMyWorldDbContext>(option => {
           return option.GetService<MyWorldDbContext>();
        });

    }
}