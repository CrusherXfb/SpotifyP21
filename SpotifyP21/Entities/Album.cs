namespace SpotifyP21.Entities;

public class Album
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Photo { get; set; }
    public required ICollection<Genre> Genres { get; set; }
    public required ICollection<Song> Songs { get; set; }
    public required ICollection<Group> Groups { get; set; }
}