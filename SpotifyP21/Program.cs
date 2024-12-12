using Microsoft.EntityFrameworkCore;
using SpotifyP21;
using SpotifyP21.Data;

var host = CreateHostBuilder(args).Build();

/*
// Настройка конфигурации
var builder = new ConfigurationBuilder()            
    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)            
    .AddJsonFile("appsettings.json");        
var configuration = builder.Build();        
var connectionString = configuration.GetConnectionString("SpotifyConnectionString");        
// Настройка сервисов
var serviceCollection = new ServiceCollection();        
serviceCollection.AddDbContext<SpotifyContext>(options =>            
options.UseNpgsql(connectionString));        
var serviceProvider = serviceCollection.BuildServiceProvider();
// Создание экземпляра контекста

using (var scope = serviceProvider.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<SpotifyContext>();
    DataSeeder.SeedData(context);
}
*/

host.Run();

static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });