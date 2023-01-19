//using ConsultaNotas.Application.InputModel;
//using ConsultaNotas.Application.Services.Interfaces;
//using Microsoft.AspNetCore.Mvc;

//namespace ConsultaNotas.API.Controllers
//{
//    [ApiController]
//    [Route("[Controller]")]

//    public class MateriasController : ControllerBase
//    {
//        private readonly IMateriaService _materiaService;
//            public MateriasController(IMateriaService materiaService)
//            {
//                _materiaService = materiaService;

//            }

//            // GET: api/aluno
//            [HttpGet]
//            // PESQUISA COM UMA STRING
//            public IActionResult Get(string query)
//            {

//                return Ok();
//            }

//            [HttpGet("{id}")]
//            // PESQUISA COM O ID , O GET PEGA AS INFORMÃÇÕES
//            public IActionResult GetById(int Id)
//            {
//                return NoContent();

//            }
//            [HttpPost]
//            //publica um aluno
//            public IActionResult Post([FromBody] NewMateriaInputModel inputModel)
//            {
//            if (inputModel.NomeMateria.Length > 50)
//            {
//                return BadRequest();
//            }
//            var IdMateria = _materiaService.Create(inputModel);

//            return CreatedAtAction(nameof(GetById), new { IdMateria = IdMateria }, inputModel);

//            }
//        }
//}
