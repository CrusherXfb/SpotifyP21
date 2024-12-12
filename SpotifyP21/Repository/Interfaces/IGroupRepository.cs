using Microsoft.AspNetCore.Mvc;
using SpotifyP21.Data;
using SpotifyP21.Dto.Group;

namespace SpotifyP21.Repository.Interfaces;

public interface IGroupRepository
{
    public Task<List<GroupDto>> GetAllAsync();

    public Task<GroupDetailsDto> GetDetailByIdAsync(int id);

    public Task DeleteByIdAsync(int id);

    public Task UpdateAsync(UpdateGroupDto updateClientDto);

    public Task CreateAsync(CreateGroupDto createGroupDto);
}