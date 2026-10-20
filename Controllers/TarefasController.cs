using Microsoft.AspNetCore.Mvc;
using TaskManager.Api.Models;

namespace TaskManager.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TarefasController : ControllerBase
    {
        private static readonly List<Tarefa> tarefas = new()
        {
            new Tarefa
            {
                Id = 1,
                Titulo = "Estudar Next.js",
                Status = "Pendente",
                Prioridade = "Alta"
            },

            new Tarefa
            {
                Id = 2,
                Titulo = "Criar API",
                Status = "Em andamento",
                Prioridade = "Média"
            },

            new Tarefa
            {
                Id = 3,
                Titulo = "Finalizar Task Manager",
                Status = "Pendente",
                Prioridade = "Alta"
            }
        };

        #region MetodoGetTodas
        [HttpGet]
        public ActionResult<List<Tarefa>> Get()
        {
            return Ok(tarefas);
        }
        #endregion

        #region MetodoGetId

        [HttpGet("{id}")]
        public ActionResult<Tarefa> GetById(int id)
        {
            var tarefa = tarefas.FirstOrDefault(t => t.Id == id);

            if (tarefa == null)
            {
                return NotFound();
            }

            return Ok(tarefa);
        }
        #endregion

        #region MetodoPost
        [HttpPost]
        public ActionResult<Tarefa> Post(Tarefa novaTarefa)
        {
            novaTarefa.Id = tarefas.Max(t => t.Id) + 1;

            tarefas.Add(novaTarefa);

            return CreatedAtAction(
                nameof(GetById),
                new { id = novaTarefa.Id },
                novaTarefa
            );
        }
        #endregion

        #region MetodoPut
        [HttpPut("{id}")]
        public IActionResult Put(int id, Tarefa tarefaAtualizada)
        {
            var tarefa = tarefas.FirstOrDefault(t => t.Id == id);

            if (tarefa == null)
            {
                return NotFound();
            }

            tarefa.Titulo = tarefaAtualizada.Titulo;
            tarefa.Status = tarefaAtualizada.Status;
            tarefa.Prioridade = tarefaAtualizada.Prioridade;

            return NoContent();
        }
        #endregion

        #region MetodoDelete

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var tarefa = tarefas.FirstOrDefault(t => t.Id == id);

            if (tarefa == null)
            {
                return NotFound();
            }

            tarefas.Remove(tarefa);

            return NoContent();
        }
        #endregion
    }
}