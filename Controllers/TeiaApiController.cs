using Microsoft.AspNetCore.Mvc;

namespace Teia_api.Controllers;

[ApiController]
//[Route("[controller]")]
[Route("api/")]
public class TeiaApiController : ControllerBase
{

    private readonly ILogger<TeiaApiController> _logger;

    public TeiaApiController(ILogger<TeiaApiController> logger)
    {
        _logger = logger;
    }
    [HttpGet]
    public string Get()
    {
        return "Desafio Teia \n" +
                " Matrícula C119972 \n" +
                "Nome: Thiago Lima de Castro";
    }

    [HttpGet]
    [Route("manipulacao-string")]
    public string Get2()
    {
        return ("Desafio Teia - Matrícula C119972 - Nome: Thiago Lima de Castro.\n" +
                "Este endpoint deve ser utilizado com método Post.");
    }


    [HttpPost]
    [Route("manipulacao-string")]
    public Palavra_atributos Post([FromBody] Palavra entrada_json)
    {
        
        return  new Palavra_atributos(entrada_json);

    }
}
