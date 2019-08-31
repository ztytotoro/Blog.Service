using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Database
{
    public static class MigrationExtension
    {
        public static void UseMigration(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();

            var context = scope.ServiceProvider.GetService<BlogContext>();

            context.Database.EnsureCreated();
        }
    }
}
