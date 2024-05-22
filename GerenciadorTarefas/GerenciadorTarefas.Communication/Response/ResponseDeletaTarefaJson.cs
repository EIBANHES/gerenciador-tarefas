using GerenciadorTarefas.Communication.Enums;

namespace GerenciadorTarefas.Communication.Response
{
    public class ResponseDeletaTarefaJson
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public PrioridadeEnum Prioridade { get; set; }
        public StatusEnum Status { get; set; }
    }
}
