using SpotifyP21.Dto.Album;
using SpotifyP21.Dto.Genre;
using SpotifyP21.Dto.Group;
using SpotifyP21.Dto.Song;
using SpotifyP21.Entities;

namespace SpotifyP21.Dto.Album;

public class AlbumDetailsDto
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Photo { get; set; }
    public required ICollection<GenreDto> Genres { get; set; }
    public required ICollection<SongDto> Songs { get; set; }
    public required ICollection<GroupDto> Groups { get; set; }
}
