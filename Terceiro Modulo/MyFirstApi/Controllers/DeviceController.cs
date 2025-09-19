using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;

// Comentei os 2 abaixo porque agora o controller herda (é derivado) de um controller base (um pai). E por isso herda dele essas duas propriedades
// [Route("api/[controller]")]
// [ApiController]
public class DeviceController : MyFirstApiBaseController
{
    [HttpGet]
    public IActionResult Get()
    {
        // Puxa do controller base essa variavel Author
        // Author = "Melissa";

        return Ok(Author);
    }
}
