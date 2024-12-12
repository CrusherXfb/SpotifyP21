using Microsoft.AspNetCore.Mvc;
using SpotifyP21.Dto.Genre;
using SpotifyP21.Dto.Song;
using SpotifyP21.Repository;
using SpotifyP21.Repository.Interfaces;

namespace SpotifyP21.Controllers;

[ApiController]
[Route("[controller]")]
public class SongController(ISongRepository songRepository) : Controller
{
    [HttpGet]
    [ActionName(nameof(GetAllAsync))]
    public async Task<List<SongDto>> GetAllAsync() =>
    await songRepository.GetAllAsync();


    [HttpGet("{id}")]
    [ActionName(nameof(GetByIdAsync))]
    public async Task<SongDto> GetByIdAsync(int id) =>
        await songRepository.GetByIdAsync(id);


    [HttpDelete("{id}")]
    [ActionName(nameof(DeleteByIdAsync))]
    public async Task DeleteByIdAsync(int id) =>
        songRepository.DeleteByIdAsync(id);


    [HttpPut]
    [ActionName(nameof(UpdateAsync))]
    public async Task UpdateAsync([FromBody] UpdateSongDto updateSongDto) =>
        songRepository.UpdateAsync(updateSongDto);


    [HttpPost]
    [ActionName(nameof(Create))]
    public async Task Create([FromBody] CreateSongDto createSongDto) =>
        songRepository.CreateAsync(createSongDto);
}
