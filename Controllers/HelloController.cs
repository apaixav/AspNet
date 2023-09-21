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
    }
}
