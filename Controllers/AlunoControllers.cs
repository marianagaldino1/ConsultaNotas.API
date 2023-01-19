using ConsultaNotas.Application.InputModel;
using ConsultaNotas.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ConsultaNotas.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

    public class AlunoControllers : ControllerBase
    {
        private readonly IAlunoService _alunoService;
        public AlunoControllers(IAlunoService alunoService)
        {
            _alunoService = alunoService;

        }

        // GET: api/aluno
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        // PESQUISA COM UMA STRING
        public IActionResult Get(string query)
        {
            var alunos = _alunoService.GetAll();

            return Ok(alunos);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        // PESQUISA COM O ID , O GET PEGA AS INFORMÃÇÕES
        public IActionResult GetById(int id)
        {
            var aluno = _alunoService.GetById(id);

            if (aluno == null)
            {
                return NotFound();
            }

            return Ok(aluno);

        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        //publica um aluno
        public IActionResult Post([FromBody] NewAlunoInputModel inputModel)
        {
            var IdAluno = _alunoService.Create(inputModel);
            return CreatedAtAction(nameof(GetById), new { IdAluno = IdAluno }, inputModel);
            
        }
        [HttpPut("{id}/start")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Start(int id)
        {
            _alunoService.Start(id);

            return NoContent();
        }

        [HttpPut("{id}/finish")]
        public IActionResult Finish(int id)
        {
            _alunoService.Finish(id);

            return NoContent();
        }


    }
}
