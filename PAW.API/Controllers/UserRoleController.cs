using Microsoft.AspNetCore.Mvc;
using PAW.DataAccess.Repositories;
using PAW.Models.DTO;

namespace PAW.API.Controllers;

[ApiController]
[Route("[controller]")]
public class UserRoleController : ControllerBase
{
    private readonly IUserRoleRepository _userRoleRepository;

    public UserRoleController(IUserRoleRepository userRoleRepository)
    {
        _userRoleRepository = userRoleRepository;
    }

    [HttpGet]
    public async Task<IEnumerable<UserRoleDTO>> GetAll()
    {
        var userRoles = await _userRoleRepository.ReadAsync();

        return userRoles.Select(UserRoleDTO.ConvertFrom);
    }
}