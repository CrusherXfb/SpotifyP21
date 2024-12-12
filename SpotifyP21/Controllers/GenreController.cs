using Microsoft.AspNetCore.Mvc;
using SpotifyP21.Dto.Genre;
using SpotifyP21.Repository;
using SpotifyP21.Repository.Interfaces;

namespace SpotifyP21.Controllers;
[ApiController]
[Route("[controller]")]
public class GenreController(IGenreRepository genreRepository) : Controller
{
    [HttpGet]
    [ActionName(nameof(GetAllAsync))]
    public async Task<List<GenreDto>> GetAllAsync() =>
    await genreRepository.GetAllAsync();


    [HttpGet("{id}")]
    [ActionName(nameof(GetByIdAsync))]
    public async Task<GenreDto> GetByIdAsync(int id) =>
        await genreRepository.GetByIdAsync(id);


    [HttpDelete("{id}")]
    [ActionName(nameof(DeleteByIdAsync))]
    public async Task DeleteByIdAsync(int id) =>
        genreRepository.DeleteByIdAsync(id);


    [HttpPut]
    [ActionName(nameof(UpdateAsync))]
    public async Task UpdateAsync([FromBody] UpdateGenreDto updateClientDto) =>
        genreRepository.UpdateAsync(updateClientDto);


    [HttpPost]
    [ActionName(nameof(Create))]
    public async Task Create([FromBody] CreateGenreDto createGroupDto) =>
        genreRepository.CreateAsync(createGroupDto);
}
