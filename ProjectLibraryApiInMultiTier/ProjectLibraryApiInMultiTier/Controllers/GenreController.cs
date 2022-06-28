using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectLibraryApiInMultiTier.BLL.Services;
using ProjectLibraryApiInMultiTier.Mappers;
using ProjectLibraryApiInMultiTier.Models;

namespace ProjectLibraryApiInMultiTier.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        GenreService _repo;

        public GenreController(GenreService repo)
        {
            this._repo = repo;
        }


        [HttpGet]
        public IActionResult Get()
        {
            //renvoie une 200 + json

            return Ok(_repo.GetAll().ToArray());
        }


        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            //renvoie une 200 + json

            return Ok(_repo.GetById(id).ToApi());
        }


        [HttpPost]
        public IActionResult AddGenre(GenreApiModel genre)
        {
            if (_repo.Insert(genre.ToDto()))
            {
                return Ok(genre);
            }
            else
            {
                return new BadRequestObjectResult(genre);
            }
        }
    }


 

  
}
