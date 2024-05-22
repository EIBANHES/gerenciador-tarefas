using GerenciadorTarefas.Application.UseCases.Tarefa.Atualizar;
using GerenciadorTarefas.Application.UseCases.Tarefa.Criar;
using GerenciadorTarefas.Application.UseCases.Tarefa.Deletar;
using GerenciadorTarefas.Application.UseCases.Tarefa.Listar;
using GerenciadorTarefas.Communication.Request;
using GerenciadorTarefas.Communication.Response;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorTarefas.Api.Controllers;

public class TarefaController : DeviceController
{

    [HttpPost]
    [ProducesResponseType(typeof(RequestCriarTarefaJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
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
        var useCase = new ListarTarefasUseCase();

        var response = useCase.Execute();

        if (response.Tarefas.Any())
        {
            return Ok(response);
        }

        return NoContent();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseShortTarefaJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult Get(int id)
    {
        var useCase = new ListarTarefaUseCase();
        var response = useCase.Execute(id);
        return Ok(response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(typeof(RequestAtualizarTarefaJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult Update(int id, [FromBody] RequestAtualizarTarefaJson request)
    {
        var useCase = new AtualizarTarefaUseCase();
        var response = useCase.Execute(id, request);

        return Ok(response);
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseDeletaTarefaJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult Delete(int id)
    {
        var useCase = new DeletarTarefaUseCase();
        var response = useCase.Execute(id);
        return Ok(response);
    }

}
