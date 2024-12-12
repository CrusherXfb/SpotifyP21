using SpotifyP21.Data;
using SpotifyP21.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SpotifyP21.Dto.Genre;
using SpotifyP21.Dto.Group;
using SpotifyP21.Entities;
using SpotifyP21.Dto.Song;

namespace SpotifyP21.Repository;

public class SongRepository(SpotifyContext spotifyContext) : ISongRepository
{
    public async Task CreateAsync(CreateSongDto createSongDto)
    {
        var song = new Song
        {
            Title = createSongDto.Title
        };

        spotifyContext.Songs.Add(song);
        await spotifyContext.SaveChangesAsync();
    }

    [HttpDelete("{id}")]
    [ActionName(nameof(DeleteByIdAsync))]
    public async Task DeleteByIdAsync(int id)
    {
        var song = await spotifyContext.Songs.SingleAsync(song => song.Id == id);
        spotifyContext.Songs.Remove(song);
        await spotifyContext.SaveChangesAsync();
    }

    public async Task<List<SongDto>> GetAllAsync() =>
         await spotifyContext.Songs.Select(
             song =>
                 new SongDto
                 {
                     Id = song.Id,
                     Title = song.Title
                 })
             .ToListAsync();

    [HttpGet("{id}")]
    [ActionName(nameof(GetByIdAsync))]
    public async Task<SongDto> GetByIdAsync(int id) =>
        await spotifyContext.Songs.Select(
             song =>
                 new SongDto
                 {
                     Id = song.Id,
                     Title = song.Title
                 })
        .SingleAsync(song => song.Id == id);


    [HttpPut]
    [ActionName(nameof(UpdateAsync))]
    public async Task UpdateAsync([FromBody] UpdateSongDto updateSongDto)
    {
        var song = await spotifyContext.Songs
            .SingleAsync(song => song.Id == updateSongDto.Id);

        song.Title = updateSongDto.Title;
        await spotifyContext.SaveChangesAsync();
    }
}
