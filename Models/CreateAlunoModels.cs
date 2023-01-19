using System.Net.Mail;

namespace ConsultaNotas.API.Models
{
    public class CreateAlunoModels
    {
        public int IdAluno { get; set; }
         
        public string Nome { get; set; }

        public string Email { get; set; }

        public string senha { get; set; }
        
        public int IdMateria { get; set; }


    }
}
