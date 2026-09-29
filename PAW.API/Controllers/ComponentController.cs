using Microsoft.AspNetCore.Mvc;
using PAW.DataAccess.Repositories;
using PAW.Models.DTO;

namespace PAW.API.Controllers;


[ApiController]
[Route("[controller]")]
public class ComponentController : Controller
{
    private readonly IComponentRepository _componentRepository;


    //Constructor para ComponentController que recibe una instancia de IComponentRepository
    public ComponentController(IComponentRepository componentRepository)
    {
        _componentRepository = componentRepository;
    }

    //Obtiene los componentes del repositorio y los convierte a DTO
    [HttpGet]
    public async Task<IEnumerable<ComponentDTO>> GetAll()
    {
        var components = await _componentRepository.ReadAsync();
        return components.Select(c => ComponentDTO.ConvertFrom(c));
    }
}
