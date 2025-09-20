using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;

[Route("api/[controller]")]
[ApiController]
// Esse abstract impede o .NET por baixo dos panos de fazer new na classe e gerar um endpoint no swagger com o nome de MyFirstApiBase
public abstract class MyFirstApiBaseController : ControllerBase
{
    public string Author { get; set; } = "Pedro Marques";

    [HttpGet("heathy")]
    public IActionResult Heathy()
    {
        return Ok("Its working");
    }

    // Esse metodo precisa ser protected porque todo metodo publico em um controller ele acha que é endpoint.. E isso é apenas um metodo de get de uma key
    protected string GetCustomKey()
    {
        // Request vem da herança de ControllerBase dessa classe
        return Request.Headers["MyKey"].ToString();
    }
}
