//using ConsultaNotas.Application.InputModel;
//using ConsultaNotas.Application.Services.Interfaces;
//using Microsoft.AspNetCore.Mvc;

//namespace ConsultaNotas.API.Controllers
//{
//a


//    public class NotaControllers : ControllerBase
//    {
//        private readonly INotasService _notasService;
//        public NotaControllers(INotasService notasService)
//        {
//            _notasService = notasService;

//        }

//        // GET: api/nota
//        [HttpGet]
//        // PESQUISA COM UMA STRING
//        public IActionResult Get(string query)
//        {

//            return Ok();
//        }

//        [HttpGet("{Nota}")]
//        // PESQUISA COM O ID , O GET PEGA AS INFORMÃÇÕES
//        public IActionResult GetById(int Nota)
//        {
//            return NoContent();

//        }
//        [HttpPost]
//        //publica uma nota
//        public IActionResult Post([FromBody] NewNotaInputModel inputModel)
//        {
//            if (inputModel.Nota.Length > 50)
//            {
//                return BadRequest();
//            }
//            var Nota = _notasService.Create(inputModel);

//            return CreatedAtAction(nameof(GetById), new { Nota = Nota }, inputModel);

//        }

//        [HttpDelete("{id}")]
//        public IActionResult Delete(int id)
//        {
//            _notasService.Delete(id);

//            return NoContent();
//        }

//        [HttpPost("{id}/nota")]
//        public IActionResult PostComment(int id, [FromBody] NewNotaInputModel inputModel)
//        {
//            _notasService.Create(inputModel);

//            return NoContent();
//        }
//        [HttpPut("{id}/start")]
//        public IActionResult Start(int id)
//        {
//            _notasService.Start(id);

//            return NoContent();
//        }
//           [HttpPut("{id}/finish")]
//        public IActionResult Finish(int id)
//        {
//            _notasService.Finish(id);

//            return NoContent();
//        }


//    }

//}