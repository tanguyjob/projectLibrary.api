using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectLibraryApiInMultiTier.BLL.Services;
using ProjectLibraryApiInMultiTier.Mappers;
using ProjectLibraryApiInMultiTier.Models;

namespace ProjectLibraryApiInMultiTier.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        UserService _repo;
        public UserController(UserService repo)
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
        public IActionResult AddUser(UserApiModel user)
        {
            if (_repo.Insert(user.ToDto()))
            {
                return Ok(user);
            }
            else
            {
                return new BadRequestObjectResult(user);
            }
        }
    }
}
