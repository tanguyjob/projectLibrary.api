using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectLibraryApiInMultiTier.BLL.Services;

namespace ProjectLibraryApiInMultiTier.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        LanguageService _repo;
        public LanguageController(LanguageService repo)
        {
            this._repo = repo;
        }
        [HttpGet]
        public IActionResult Get()
        {
            //renvoie une 200 + json

            return Ok(_repo.GetAll().ToArray());
        }
    }
}
