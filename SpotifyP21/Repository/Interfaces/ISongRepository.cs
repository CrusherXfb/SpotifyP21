using SpotifyP21.Dto.Genre;
using SpotifyP21.Dto.Song;

namespace SpotifyP21.Repository.Interfaces
{
    public interface ISongRepository
    {
        public Task<List<SongDto>> GetAllAsync();

        public Task<SongDto> GetByIdAsync(int id);

        public Task DeleteByIdAsync(int id);

        public Task UpdateAsync(UpdateSongDto updateSongDto);

        public Task CreateAsync(CreateSongDto createSongDto);
    }
}
