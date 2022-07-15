using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectLibraryApiInMultiTier.BLL.Services;
using ProjectLibraryApiInMultiTier.Mappers;
using ProjectLibraryApiInMultiTier.Models;

namespace ProjectLibraryApiInMultiTier.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        BookService _repo;

        public BookController(BookService repo)
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

        [HttpGet]
        [Route("GetBookByAuthorId/{id}")]
        public IActionResult GetBookByAuthorId(int id)
        {
            //renvoie une 200 + json

            return Ok(_repo.GetBookByAuthorId(id));
        }

        [HttpPost]
        public IActionResult AddBook(BookApiModel book)
        {
            if (_repo.Insert(book.ToDto()))
            {
                return Ok(book);
            }
            else
            {
                return new BadRequestObjectResult(book);
            }
        }
    }
}
