using GerenciadorTarefas.Communication.Response;

namespace GerenciadorTarefas.Application.UseCases.Tarefa.Deletar
{
    public class DeletarTarefaUseCase
    {
        public ResponseDeletaTarefaJson Execute(int id)
        {
            return new ResponseDeletaTarefaJson
            {
                Id = id,
                Nome = "deletando",
                Descricao = "delete",
                Prioridade = Communication.Enums.PrioridadeEnum.Alta,
                Status = Communication.Enums.StatusEnum.Concluido,
            };
        }
    }
}
