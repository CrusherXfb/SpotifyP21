using SpotifyP21.Dto.Genre;

namespace SpotifyP21.Repository.Interfaces
{
    public interface IGenreRepository
    {
        public Task<List<GenreDto>> GetAllAsync();

        public Task<GenreDto> GetByIdAsync(int id);

        public Task DeleteByIdAsync(int id);

        public Task UpdateAsync(UpdateGenreDto updateGenreDto);

        public Task CreateAsync(CreateGenreDto createGenreDto);
    }
}
