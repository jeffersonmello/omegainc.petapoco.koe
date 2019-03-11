using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using OmegaInc.KOE.Repositories.Cadastro.Item;
using OmegaInc.KOE.Web.Model.Cadastro.Item;

namespace OmegaInc.KOE.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicasController : ControllerBase
    {
        private readonly MusicasRepository musicasRepository;

        public MusicasController(IConfiguration configuration)
        {
            musicasRepository = new MusicasRepository(configuration);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Musica>> Get()
        {
            return musicasRepository.FindAll().ToList();
        }
    }
}