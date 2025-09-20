using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;

// ANOTAÇÕES GERAIS SOBRE HERANÇA
// - Quando queremos obrigar uma classe derivada (filha ) a implementar um metodo ou uma propriedade, a gente coloca na classe base "abstract", e no metodo ou pripriedade também.
// - Quando queremos dar acesso a um metodo ou propriedade somente a classe e a quem é derivada dela, usamos o protected (diferente do private que deixa somente a classe base utilizar)
// - Overide significa uma sobre-escrita de um abstract derivado. Assim nos nao mudamos a funcao original da classe pai mas sim criamos uma copia e sobrescrevemos.
// - Virtual diz que a classe derivada tem permissao de reescrever esse metodo. 

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
