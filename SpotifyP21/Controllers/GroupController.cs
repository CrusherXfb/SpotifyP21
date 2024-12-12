using Microsoft.AspNetCore.Mvc;
using SpotifyP21.Dto.Group;
using SpotifyP21.Repository.Interfaces;

namespace SpotifyP21.Controllers;

[ApiController]
[Route("[controller]")]
public class GroupController(IGroupRepository groupRepository) : Controller
{
    [HttpGet]
    [ActionName(nameof(GetAllAsync))]
    public async Task<List<GroupDto>> GetAllAsync() =>
        await groupRepository.GetAllAsync();


    [HttpGet("{id}")]
    [ActionName(nameof(GetDetailByIdAsync))]
    public async Task<GroupDetailsDto> GetDetailByIdAsync(int id) => 
        await groupRepository.GetDetailByIdAsync(id);


    [HttpDelete("{id}")]
    [ActionName(nameof(DeleteByIdAsync))]
    public async Task DeleteByIdAsync(int id) =>
        groupRepository.DeleteByIdAsync(id);


    [HttpPut]
    [ActionName(nameof(UpdateAsync))]
    public async Task UpdateAsync([FromBody] UpdateGroupDto updateClientDto) =>
        groupRepository.UpdateAsync(updateClientDto);


    [HttpPost]
    [ActionName(nameof(Create))]
    public async Task Create([FromBody] CreateGroupDto createGroupDto) =>
        groupRepository.CreateAsync(createGroupDto);
}