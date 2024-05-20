using GerenciadorTarefas.Communication.Request;

namespace GerenciadorTarefas.Application.UseCases.Tarefa.Criar;
public class CriarTarefaUseCase
{
    public RequestCriarTarefaJson Execute(RequestCriarTarefaJson request)
    {
        return new RequestCriarTarefaJson
        {
            Id = request.Id,
            Nome = request.Nome,
            Descricao = request.Descricao,
            Prioridade = request.Prioridade,
            DataLimite = request.DataLimite,
            Status = request.Status,
        };
    }
}
