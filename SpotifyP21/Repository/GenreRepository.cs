using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SpotifyP21.Data;
using SpotifyP21.Dto.Genre;
using SpotifyP21.Dto.Group;
using SpotifyP21.Entities;
using SpotifyP21.Repository.Interfaces;

namespace SpotifyP21.Repository;

public class GenreRepository(SpotifyContext spotifyContext) : IGenreRepository
{

    public async Task CreateAsync(CreateGenreDto createGenreDto)
    {
        var genre = new Genre
        {
            Title = createGenreDto.Title
        };

        spotifyContext.Genres.Add(genre);
        await spotifyContext.SaveChangesAsync();
    }

    [HttpDelete("{id}")]
    [ActionName(nameof(DeleteByIdAsync))]
    public async Task DeleteByIdAsync(int id)
    {
        var genre = await spotifyContext.Genres.SingleAsync(genre => genre.Id == id);
        spotifyContext.Genres.Remove(genre);
        await spotifyContext.SaveChangesAsync();
    }

    public async Task<List<GenreDto>> GetAllAsync() =>
         await spotifyContext.Genres.Select(
             genre =>
                 new GenreDto
                 {
                     Id = genre.Id,
                     Title = genre.Title
                 })
             .ToListAsync();

    [HttpGet("{id}")]
    [ActionName(nameof(GetByIdAsync))]
    public async Task<GenreDto> GetByIdAsync(int id) =>
        await spotifyContext.Genres.Select(
             genre =>
                 new GenreDto
                 {
                     Id = genre.Id,
                     Title = genre.Title
                 })
        .SingleAsync(genre => genre.Id == id);


    [HttpPut]
    [ActionName(nameof(UpdateAsync))]
    public async Task UpdateAsync([FromBody] UpdateGenreDto updateGenreDto)
    {
        var genre = await spotifyContext.Groups
            .SingleAsync(genre => genre.Id == updateGenreDto.Id);

        genre.Title = updateGenreDto.Title;
        await spotifyContext.SaveChangesAsync();
    }

}

