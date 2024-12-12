using Microsoft.EntityFrameworkCore;
using SpotifyP21.Data;
using SpotifyP21.Repository;
using SpotifyP21.Repository.Interfaces;

namespace SpotifyP21;

public class Startup(IConfiguration configuration)
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();

        services.AddSwaggerGen();

        services.AddDbContext<SpotifyContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("SpotifyConnectionString")));

        services.AddTransient<IGroupRepository, GroupRepository>();
        services.AddTransient<IGenreRepository, GenreRepository>();
        services.AddTransient<IAlbumRepository, AlbumRepository>();
        services.AddTransient<ISongRepository, SongRepository>();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }


        app.UseRouting();
        app.UseHttpsRedirection();
        app.UseSwagger();
        app.UseSwaggerUI();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}