using Microsoft.EntityFrameworkCore;
using SpotifyP21.Entities;

namespace SpotifyP21.Data;

public class SpotifyContext(DbContextOptions<SpotifyContext> options) : DbContext(options)
{
    public DbSet<Album> Albums { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Song> Songs { get; set; }
}