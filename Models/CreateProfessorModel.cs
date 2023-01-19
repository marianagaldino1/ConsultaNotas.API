using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsultaNotas.API.Models
{
    public class CreateProfessorModel
    {
        public int IdProfessor { get; set; }

        public string Nome { get; set; }
        
        public string Email { get; set; }
        
        public string senha { get; set; }

        public int IdMateria { get; set; }



    }
}
