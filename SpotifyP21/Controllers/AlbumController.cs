using Microsoft.AspNetCore.Mvc;
using SpotifyP21.Dto.Genre;
using SpotifyP21.Dto.Group;
using SpotifyP21.Dto.Album;
using SpotifyP21.Repository;
using SpotifyP21.Repository.Interfaces;

namespace SpotifyP21.Controllers;

[ApiController]
[Route("[controller]")]
public class AlbumController(IAlbumRepository albumRepository) : Controller
{
    [HttpGet]
    [ActionName(nameof(GetAllAsync))]
    public async Task<List<AlbumDto>> GetAllAsync() =>
        await albumRepository.GetAllAsync();


    [HttpGet("{id}")]
    [ActionName(nameof(GetDetailByIdAsync))]
    public async Task<AlbumDetailsDto> GetDetailByIdAsync(int id) =>
        await albumRepository.GetDetailByIdAsync(id);


    [HttpDelete("{id}")]
    [ActionName(nameof(DeleteByIdAsync))]
    public async Task DeleteByIdAsync(int id) =>
        albumRepository.DeleteByIdAsync(id);


    [HttpPut]
    [ActionName(nameof(UpdateAsync))]
    public async Task UpdateAsync([FromBody] UpdateAlbumDto updateAlbumDto) =>
        albumRepository.UpdateAsync(updateAlbumDto);


    [HttpPost]
    [ActionName(nameof(Create))]
    public async Task Create([FromBody] CreateAlbumDto createAlbumDto) =>
        albumRepository.CreateAsync(createAlbumDto);
}
