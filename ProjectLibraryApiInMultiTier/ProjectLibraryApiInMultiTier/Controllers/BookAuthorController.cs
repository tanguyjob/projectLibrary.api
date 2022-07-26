using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectLibraryApiInMultiTier.BLL.Services;
using ProjectLibraryApiInMultiTier.Mappers;
using ProjectLibraryApiInMultiTier.Models;

namespace ProjectLibraryApiInMultiTier.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookAuthorController : ControllerBase
    {
        BookAuthorService _repo;

        public BookAuthorController(BookAuthorService repo)
        {
            this._repo = repo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            //renvoie une 200 + json

            return Ok(_repo.GetAll().ToArray());
        }

        [HttpPost]
        public IActionResult AddBookAuthor(BookAuthorApiModel model)
        {
            if (_repo.Insert(model.ToDto()))
            {
                return Ok(model);
            }
            else
            {
                return new BadRequestObjectResult(model);
            }
        }

    }
}
