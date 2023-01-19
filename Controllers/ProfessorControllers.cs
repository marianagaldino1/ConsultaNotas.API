//using ConsultaNotas.Application.InputModel;
//using ConsultaNotas.Application.Services.Interfaces;
//using Microsoft.AspNetCore.Mvc;

//namespace ConsultaNotas.API.Controllers
//{

//    [ApiController]
//    [Route("[Controller]")]
//    public class ProfessorControllers : ControllerBase
//    {
//        private readonly IProfessorService _professorService;
//        public ProfessorControllers(IProfessorService professorService)
//        {
//            _professorService = professorService;
//        }
//        [HttpGet]
//        public IActionResult Get(string query)
//        {
//            var professor = _professorService.GetAll();

//            return Ok(professor);
//        }

//        [HttpGet("{id}")]
//        public IActionResult GetById(int id)
//        {
//            var professor = _professorService.GetById(id);

//            if (professor == null)
//            {
//                return NotFound();
//            }

//            return Ok(professor);
//        }


//        [HttpPost]
//        public IActionResult Post([FromBody] NewProfessorInputModel inputModel)
//        {
//            if (inputModel.NomeProfessor.Length > 50)
//            {
//                return BadRequest();
//            }

//            var id = _professorService.Create(inputModel);

//            return CreatedAtAction(nameof(GetById), new { id = id }, inputModel);
//        }

//        [HttpDelete("{id}")]
//        public IActionResult Delete(int id)
//        {
//            _professorService.Delete(id);

//            return NoContent();
//        }
//        public IActionResult Start(int id)
//        {
//            _professorService.Start(id);

//            return NoContent();
//        }

//        // api/projects/1/finish
//        [HttpPut("{id}/finish")]
//        public IActionResult Finish(int id)
//        {
//            _professorService.Finish(id);

//            return NoContent();
//        }

//    }
//}
