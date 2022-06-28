using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectLibraryApiInMultiTier.BLL.Services;
using ProjectLibraryApiInMultiTier.Mappers;
using ProjectLibraryApiInMultiTier.Models;

namespace ProjectLibraryApiInMultiTier.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        AuthorService _repo;
        public AuthorController(AuthorService repo)
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

            return Ok(_repo.GetById(id));
        }

        [HttpPost]
        public IActionResult AddAuthor(AuthorApiModel author)
        {
            if (_repo.Insert(author.ToDto()))
            {
                return Ok(author);
            }
            else
            {
                return new BadRequestObjectResult(author);
            }
        }
    }
}
