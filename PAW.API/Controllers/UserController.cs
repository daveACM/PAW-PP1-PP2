using Microsoft.AspNetCore.Mvc;
using PAW.DataAccess.Repositories;
using PAW.Models.DTO;

namespace PAW.API.Controllers;

// Controlador de la API encargado de gestionar las solicitudes relacionadas con los usuarios.
[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserRepository _userRepository;

    // Recibe el repositorio de usuarios mediante inyección de dependencias.
    public UserController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    // Obtiene todos los usuarios almacenados en la base de datos y convierte cada entidad User en un UserDTO antes de retornarlos.
    [HttpGet]
    public async Task<IEnumerable<UserDTO>> GetAll()
    {
        var users = await _userRepository.ReadAsync();

        return users.Select(UserDTO.ConvertFrom);
    }
}