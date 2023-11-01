using AlunosApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlunosApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunosController : ControllerBase
    {
        private readonly IAlunoService _service;

        public AlunosController(IAlunoService service)
        {
            _service = service;
        }
    }
}


// https://www.youtube.com/watch?v=d_ziX6z2ros&list=PLJ4k1IC8GhW1xK5YEkiYdbWiOiXHMZyen&index=3