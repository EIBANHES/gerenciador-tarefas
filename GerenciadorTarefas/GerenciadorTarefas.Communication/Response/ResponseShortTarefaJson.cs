using GerenciadorTarefas.Communication.Enums;

namespace GerenciadorTarefas.Communication.Response;
public class ResponseShortTarefaJson
{
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public PrioridadeEnum Prioridade { get; set; }
    public StatusEnum Status { get; set; }
}
