using SpotifyP21.Dto.Album;
using SpotifyP21.Dto.Genre;
using SpotifyP21.Entities;

namespace SpotifyP21.Dto.Group;

public class GroupDetailsDto
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required ICollection<GenreDto> Genres { get; set; }
    public required ICollection<AlbumDto> Albums { get; set; }
}