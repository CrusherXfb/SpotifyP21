namespace SpotifyP21.Dto.Album
{
    public class UpdateAlbumDto
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Photo { get; set; }
        public required List<int> Genres { get; set; }
        public required List<int> Songs { get; set; }
        public required List<int> Groups { get; set; }
    }
}
