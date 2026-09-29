using Microsoft.AspNetCore.Mvc;
using PAW.DataAccess.Repositories;
using PAW.Models.DTO;

namespace PAW.API.Controllers;


[ApiController]
[Route("[controller]")]
public class RoleController : ControllerBase
{
    private readonly IRoleRepository _roleRepository;
    //Constructor for the RoleController
    public RoleController(IRoleRepository roleRepository)
    {
        _roleRepository = roleRepository;
    }
    // GET: /Role
    [HttpGet]
    public async Task<IEnumerable<RoleDTO>> GetAll()
    {
        var roles = await _roleRepository.ReadAsync();
        return roles.Select(RoleDTO.ConvertFrom);
    }
}
