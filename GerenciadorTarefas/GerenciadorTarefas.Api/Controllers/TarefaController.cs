using GerenciadorTarefas.Application.UseCases.Tarefa.Criar;
using GerenciadorTarefas.Application.UseCases.Tarefa.Listar;
using GerenciadorTarefas.Communication.Request;
using GerenciadorTarefas.Communication.Response;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorTarefas.Api.Controllers;

public class TarefaController : DeviceController
{

    [HttpPost]
    [ProducesResponseType(typeof(RequestCriarTarefaJson), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestCriarTarefaJson request)
    {
        var useCase = new CriarTarefaUseCase();

        var response = useCase.Execute(request);

        return Created(string.Empty, response);
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseTodasTarefasJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll()
    {
        var useCase = new ListarTarefaUseCase();

        var response = useCase.Execute();

        if (response.Tarefas.Any())
        {
            return Ok(response);
        }

        return NoContent();
    }

}
