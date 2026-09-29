using Microsoft.AspNetCore.Mvc;
using PAW.DataAccess.Repositories;
using PAW.Models.DTO;

namespace PAW.API.Controllers;

// Controlador de la API encargado de gestionar las solicitudes relacionadas con las acciones de usuario.
[ApiController]
[Route("[controller]")]
public class UserActionController : ControllerBase
{
    private readonly IUserActionRepository _userActionRepository;

    // Recibe el repositorio de acciones de usuario mediante inyección de dependencias.
    public UserActionController(
        IUserActionRepository userActionRepository)
    {
        _userActionRepository = userActionRepository;
    }

    // Obtiene todas las acciones de usuario almacenadas en la base de datos y convierte cada entidad UserAction en un UserActionDTO antes de retornarlas.
    [HttpGet]
    public async Task<IEnumerable<UserActionDTO>> GetAll()
    {
        var userActions = await _userActionRepository.ReadAsync();

        return userActions.Select(UserActionDTO.ConvertFrom);
    }
}