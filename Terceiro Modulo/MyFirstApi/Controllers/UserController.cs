using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Communication.Requests;
using MyFirstApi.Communication.Responses;

namespace MyFirstApi.Controllers;

[Route("api/[controller]")] // O atribulo [controller] vai ser sempre o nome dessa classe retirando Controller da frase. No caso (UserController = User)
[ApiController] //Atributo que define a classe como controller
public class UserController : ControllerBase
{
    [HttpGet] // Indica o metodo HTTP da funcao. No caso é um get
    [Route("{id}")] //Aplica o parametro como parte da rota (path)
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)] // Documenta no swagger o tipo de resposta.. Poderia ser uma resposta tipada -> typeof(Response)
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)] // Pode ter mais de uma opcao de statusCode
    // Endpoint sempre devolver essa interface de IActionResult
    // Esse FromRoute diz de onde aquele parametro vem. Poderia ser FromQuery também. Se nao tiver nenhuma declaracao ele infere que vem de query. Se tiver Route ali em cima ele infere que vem da rota. Para header tem que inferir manualmente
    public IActionResult GetById([FromRoute] int id)
    {
        // Objeto anonimo. Sem tipagem
        var response = new { Name = "Pedro", Age = 26 };
        //Objeto tipado por classe
        var typeResponse = new User()
        {
            Id = 1,
            Name = "Pedro Marques",
            Age = 26
        };

        return Ok(typeResponse);
    }


    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredUserJson), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestRegisterUserJson request)
    {
        var response = new ResponseRegisteredUserJson
        {
            Id = 1,
            Name = request.Name
        };

        return Created(string.Empty, response);
    }


    [HttpPut]
    // [Route("{id}")] Duas formas de alterar informações de usuario.. Ou por id na rota (menos comum), ou por token de autenticação (usuario logado)
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromBody] RequestUpdateUserProfileJson request)
    {
        return NoContent();
    }


    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete()
    {
        return NoContent();
    }


    [HttpGet]
    [ProducesResponseType(typeof(List<User>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var response = new List<User>()
        {
            new User { Id= 1, Age= 26, Name= "Pedro Marques" },
            new User { Id= 2, Age= 23, Name= "Melissa" }
        };

        return Ok(response);
    }


    [HttpPut("change-password")] // Para nao conflitar rota com outro put, precisa colocar um diferencial na rota. Seja passar um parametro como id ou um novo complemento de nome.
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult ChangePassword([FromBody] RequestChangePasswordJson request)
    {
        return NoContent();
    }
}
