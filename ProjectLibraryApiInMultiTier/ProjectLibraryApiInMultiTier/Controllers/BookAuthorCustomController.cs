using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectLibraryApiInMultiTier.BLL.Services;

namespace ProjectLibraryApiInMultiTier.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookAuthorCustomController : ControllerBase
    {
        BookAuthorCustomService _repo;

        public BookAuthorCustomController(BookAuthorCustomService repo)
        {
            this._repo = repo;
        }


        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            //renvoie une 200 + json

            return Ok(_repo.GetByBookId(id).ToArray());
        }
    }
}
