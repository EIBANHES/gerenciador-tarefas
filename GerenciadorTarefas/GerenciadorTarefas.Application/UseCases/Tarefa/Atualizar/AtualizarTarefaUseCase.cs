using GerenciadorTarefas.Communication.Request;

namespace GerenciadorTarefas.Application.UseCases.Tarefa.Atualizar
{
    public class AtualizarTarefaUseCase
    {
        public RequestAtualizarTarefaJson Execute(int id, RequestAtualizarTarefaJson request)
        {
            return new RequestAtualizarTarefaJson
            {
                Nome = request.Nome,
                Descricao = request.Descricao,
                Prioridade = request.Prioridade,
                Status = request.Status,
            };
        }
    }
}
