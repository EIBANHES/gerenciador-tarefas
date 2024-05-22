using GerenciadorTarefas.Communication.Response;

namespace GerenciadorTarefas.Application.UseCases.Tarefa.Listar
{
    public class ListarTarefaUseCase
    {
        public ResponseShortTarefaJson Execute(int id)
        {
            return new ResponseShortTarefaJson
            {
                Id = id,
                Nome = "Liste",
                Descricao = "por id",
                Prioridade = Communication.Enums.PrioridadeEnum.Baixa,
                Status = Communication.Enums.StatusEnum.Em_Andamento
            };
        }
    }
}
