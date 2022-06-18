using Infrastructere.Data;

namespace WebAPI.Extensions
{
    public static class HostExtensions
    {
        public static async Task SeedDataAsync(this IHost host)
        {

            using (var scope = host.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
                await ApplicationContextSeed.SeedAsync(dbContext);
            }
        }
    }
}
