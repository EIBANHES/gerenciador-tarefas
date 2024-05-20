using GerenciadorTarefas.Communication.Enums;

namespace GerenciadorTarefas.Communication.Request;
public class RequestCriarTarefaJson
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public PrioridadeEnum Prioridade { get; set; }
    public DateTime DataLimite { get; set; }
    public StatusEnum Status { get; set; }
}
