using Microsoft.AspNetCore.Mvc;
using PAW.DataAccess.Repositories;
using PAW.Models.DTO;

namespace PAW.API.Controllers;


[ApiController]
[Route("[controller]")]
public class PawTaskController : ControllerBase
{
    private readonly IPawTaskRepository _pawTaskRepository;

    public PawTaskController(IPawTaskRepository pawTaskRepository)
    {
        _pawTaskRepository = pawTaskRepository;
    }

    // GET: /PawTask
    [HttpGet]
    public async Task<IEnumerable<PawTaskDTO>> GetAll()
    {
        var tasks = await _pawTaskRepository.ReadAsync();
        return tasks.Select(PawTaskDTO.ConvertFrom);
    }
}
