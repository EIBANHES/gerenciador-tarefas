using GerenciadorTarefas.Communication.Response;

namespace GerenciadorTarefas.Application.UseCases.Tarefa.Listar;
public class ListarTarefaUseCase
{
    public ResponseTodasTarefasJson Execute()
    {
        return new ResponseTodasTarefasJson
        {
            Tarefas = new List<ResponseShortTarefaJson>
            {
                new ResponseShortTarefaJson
                {
                    Nome = "Teste",
                    Descricao = "Teste",
                    Prioridade = Communication.Enums.PrioridadeEnum.Baixa,
                    Status = Communication.Enums.StatusEnum.Em_Andamento
                }
            }
        };
    }
}
