using SpotifyP21.Dto.Album;
using SpotifyP21.Dto.Genre;
using SpotifyP21.Dto.Group;

namespace SpotifyP21.Repository.Interfaces
{
    public interface IAlbumRepository
    {
        public Task<List<AlbumDto>> GetAllAsync();

        public Task<AlbumDetailsDto> GetDetailByIdAsync(int id);

        public Task DeleteByIdAsync(int id);

        public Task UpdateAsync(UpdateAlbumDto updateAlbumDto);

        public Task CreateAsync(CreateAlbumDto createGAlbumDto);


    }
}
