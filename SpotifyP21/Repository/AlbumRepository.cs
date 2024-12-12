using SpotifyP21.Data;
using SpotifyP21.Dto.Album;
using SpotifyP21.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SpotifyP21.Dto.Genre;
using SpotifyP21.Dto.Group;
using SpotifyP21.Entities;
using SpotifyP21.Dto.Song;

namespace SpotifyP21.Repository
{
    public class AlbumRepository(SpotifyContext spotifyContext) : IAlbumRepository
    {
        public async Task CreateAsync(CreateAlbumDto createAlbumDto)
        {
            var genres = await spotifyContext.Genres
                .Where(genre => createAlbumDto.Genres.Contains(genre.Id))
                .ToListAsync();

            var groups = await spotifyContext.Groups
                .Where(group => createAlbumDto.Groups.Contains(group.Id))
                .ToListAsync();

            var songs = await spotifyContext.Songs
                .Where(song => createAlbumDto.Songs.Contains(song.Id))
                .ToListAsync();

            var album = new Album
            {
                Title = createAlbumDto.Title,
                Photo = createAlbumDto.Photo,
                Genres = genres,
                Groups = groups,
                Songs = songs

            };

            spotifyContext.Albums.Add(album);
            await spotifyContext.SaveChangesAsync();
        }

        [HttpDelete("{id}")]
        [ActionName(nameof(DeleteByIdAsync))]
        public async Task DeleteByIdAsync(int id)
        {
            var album = await spotifyContext.Albums.SingleAsync(album => album.Id == id);
            spotifyContext.Albums.Remove(album);

            await spotifyContext.SaveChangesAsync();
        }

        public async Task<List<AlbumDto>> GetAllAsync() =>
         await spotifyContext.Albums.Select(
             album =>
                 new AlbumDto
                 {
                     Id = album.Id,
                     Title = album.Title,
                     Photo = album.Photo
                 })
             .ToListAsync();

        [HttpGet("{id}")]
        [ActionName(nameof(GetDetailByIdAsync))]
        public async Task<AlbumDetailsDto> GetDetailByIdAsync(int id) =>
        await spotifyContext.Albums
        .Include(album => album.Genres)
        .Include(album => album.Groups)
        .Include(album => album.Songs)
        .Select(
            album =>
                new AlbumDetailsDto
                {
                    Id = album.Id,
                    Title = album.Title,
                    Photo = album.Photo,

                    Groups = album.Groups
                    .Select(group => new GroupDto
                    {
                        Id = group.Id,
                        Title = group.Title
                    }).ToList(),
                    Genres = album.Genres
                    .Select(genre => new GenreDto
                    {
                        Id = genre.Id,
                        Title = genre.Title
                    }).ToList(),
                    Songs = album.Songs
                    .Select(song => new SongDto
                     { 
                        Id = song.Id,
                        Title = song.Title
                     }).ToList()
                })
        .SingleAsync(album => album.Id == id);

        [HttpPut]
        [ActionName(nameof(UpdateAsync))]
        public async Task UpdateAsync([FromBody] UpdateAlbumDto updateAlbumDto)
        {
            var album= await spotifyContext.Albums
                .Include(album => album.Genres)
                .Include(album => album.Groups)
                .Include(album => album.Songs)
                .SingleAsync(album => album.Id == updateAlbumDto.Id);

            album.Title = updateAlbumDto.Title;
            album.Photo = updateAlbumDto.Photo;

            var genres = await spotifyContext.Genres
                .Where(genre => updateAlbumDto.Genres.Contains(genre.Id))
                .ToListAsync();

            var groups = await spotifyContext.Groups
                .Where(group => updateAlbumDto.Groups.Contains(group.Id))
                .ToListAsync();

            var songs = await spotifyContext.Songs
                .Where(song => updateAlbumDto.Songs.Contains(song.Id))
                .ToListAsync();

            album.Genres.Clear();
            album.Songs.Clear();
            album.Groups.Clear();

            album.Genres = genres;
            album.Songs = songs;
            album.Groups = groups;

            await spotifyContext.SaveChangesAsync();
        }
    }
}
