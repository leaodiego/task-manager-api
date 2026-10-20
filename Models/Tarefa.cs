namespace TaskManager.Api.Models
{
    public class Tarefa
    {
        public int Id { get; set; }

        public string Titulo { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty;

        public string Prioridade { get; set; } = string.Empty;
    }
}