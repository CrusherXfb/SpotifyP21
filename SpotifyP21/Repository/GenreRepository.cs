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


    public async Task<GenreDto> GetByIdAsync(int id) =>
        await spotifyContext.Genres.Select(
             genre =>
                 new GenreDto
                 {
                     Id = genre.Id,
                     Title = genre.Title
                 })
        .SingleAsync(genre => genre.Id == id);



    public async Task UpdateAsync([FromBody] UpdateGenreDto updateGenreDto)
    {
        var genre = await spotifyContext.Genres
            .SingleAsync(genre => genre.Title == "MyNewGenre1111111111");

        genre.Title = updateGenreDto.Title;
        await spotifyContext.SaveChangesAsync();
    }

}

