using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{


    [Route("~/")]
    [ApiController]
    public class HelloController
    {
        [HttpGet]
        public string Hello()
        {
            return "Hello turma .NET 03";
        }

        [HttpGet("/meunome")]
        public string MeuNome()
        {
            return "Lucas";
        }

        [HttpGet("/bsm")]
        public string Bsm()
        {
            return "Trabalho em equipe \n Atenção aos detalhes \n Proatividade \n Comunicação" +
                "\n Orientação ao Futuro \n Responsabilidade Pessoal \n Mentalidade de crescimento \n Persistência";
        }

        [HttpGet("/objetivos")]
        public string Objetivo()
        {
            return "Aprender, estudar, e desenvolver códigos sobre ASP.Net  ";
        }
    }
}
